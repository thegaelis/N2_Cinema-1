﻿using GUI.DAO;
using GUI.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;//thư viện thay đổi vùng/quốc gia
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class frmTheatre : Form
    {
        int SIZE = 30;//Size của ghế
        int GAP = 7;//Khoảng cách giữa các ghế

        List<Ticket> listSeat = new List<Ticket>();

        Dictionary<string, float> priceOfTicket = new Dictionary<string, float>();

        //dùng lưu vết các Ghế đang chọn
        List<Button> listSeatSelected = new List<Button>();

        float displayPrice = 0;//Hiện thị giá vé
        float ticketPrice = 0;//Lưu giá vé gốc
        float total = 0;//Tổng giá tiền
        float discount = 0;//Tiền được giảm
        float payment = 0;//Tiền phải trả
        int plusPoint = 0;//Số điểm tích lũy khi mua vé

        Customer customer;//lưu lại khách hàng thành viên

        ShowTimes Times;
        Movie Movie;


        public frmTheatre(ShowTimes showTimes, Movie movie)
        {
            InitializeComponent();

            Times = showTimes;
            Movie = movie;
        }

        private void frmTheatre_Load(object sender, EventArgs e)
        {
            ticketPrice = Times.TicketPrice;

            lblInformation.Text = "CGV | " + Times.CinemaName + " | " + Times.MovieName;
            lblTime.Text = Times.Time.ToShortDateString() + " | "
                + Times.Time.ToShortTimeString() + " - "
                + Times.Time.AddMinutes(Movie.Time).ToShortTimeString();
            if (Movie.Poster != null)
                picFilm.Image = MovieDAO.byteArrayToImage(Movie.Poster);

            rdoAdult.Checked = true;
            chkCustomer.Enabled = false;
            grpLoaiVe.Enabled = false;

            LoadDataCinema(Times.CinemaName);

            ShowOrHideLablePoint();

            listSeat = TicketDAO.GetListTicketsByShowTimes(Times.ID);

            LoadSeats(listSeat);
        }

        private void LoadDataCinema(string cinemaName)
        {
            Cinema cinema = CinemaDAO.GetCinemaByName(cinemaName);
            int Row = cinema.Row;
            int Column = cinema.SeatInRow;
            flpSeat.Size = new Size((SIZE + 20 + GAP) * Column, (SIZE + GAP) * Row);
        }

        private void LoadBill()
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            //Đổi culture vùng quốc gia để đổi đơn vị tiền tệ 

            //Thread.CurrentThread.CurrentCulture = culture;
            //dùng thread để chuyển cả luồng đang chạy về vùng quốc gia đó

            lblTicketPrice.Text = displayPrice.ToString("c", culture);
            lblTotal.Text = total.ToString("c", culture);
            lblDiscount.Text = discount.ToString("c", culture);
            lblPayment.Text = payment.ToString("c", culture);

            //Đổi đơn vị tiền tệ
            //gán culture chỗ này thì chỉ có chỗ này sd culture này còn
            //lại sài mặc định
        }

        private void LoadSeats(List<Ticket> list)
        {
            flpSeat.Controls.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                Button btnSeat = new Button() { Width = SIZE + 20, Height = SIZE };
                btnSeat.Text = list[i].SeatName;
                if (list[i].Status == 1)
                    btnSeat.BackColor = Color.Red;
                else
                    btnSeat.BackColor = Color.White;
                btnSeat.Click += BtnSeat_Click;
                flpSeat.Controls.Add(btnSeat);

                btnSeat.Tag = list[i];
            }
        }

        private void BtnSeat_Click(object sender, EventArgs e)
        {
            Button btnSeat = sender as Button;
            if (btnSeat.BackColor == Color.White)
            {
                grpLoaiVe.Enabled = true;
                rdoAdult.Checked = true;

                btnSeat.BackColor = Color.Yellow;
                Ticket ticket = btnSeat.Tag as Ticket;

                ticket.Price = ticketPrice;
                displayPrice = ticket.Price;
                total += ticketPrice;
                payment = total - discount;
                ticket.Type = 1;

                listSeatSelected.Add(btnSeat);
                plusPoint++;
                lblPlusPoint.Text = plusPoint + "";

                priceOfTicket.Add(btnSeat.Text, displayPrice);
            }
            else if (btnSeat.BackColor == Color.Yellow)
            {
                btnSeat.BackColor = Color.White;
                Ticket ticket = btnSeat.Tag as Ticket;

                total -= ticket.Price;
                payment = total - discount;
                ticket.Price = 0;
                displayPrice = ticket.Price;
                ticket.Type = 0;

                listSeatSelected.Remove(btnSeat);
                plusPoint--;
                lblPlusPoint.Text = plusPoint + "";
                grpLoaiVe.Enabled = false;


                priceOfTicket.Remove(btnSeat.Text);
            }
            else if (btnSeat.BackColor == Color.Red)
            {
                MessageBox.Show("Ghế số [" + btnSeat.Text + "] đã có người mua");
            }
            LoadBill();
            if (listSeatSelected.Count > 0)
            {
                chkCustomer.Enabled = true;
            }
            else
            {
                chkCustomer.Enabled = false;
            }
        }
        //load các vé vào danh sách in
        private void LoadListExpotingttk()
        {
            if (ListExportingtk.ExportingtkList.Count>0)
            {
                ListExportingtk.ExportingtkList.Clear ();
            }
            DateTime now = DateTime.Now;
            string current = now.ToString();
            foreach(Button btn in listSeatSelected)
            {
                //ListExportingtk.ExportingtkList.Add(new Exportingtk(current, lblInformation.Text, btn.Text, lblTime.Text, 85000));
                float value;
                if (priceOfTicket.TryGetValue(btn.Text, out value))
                {
                    ListExportingtk.ExportingtkList.Add(new Exportingtk(current, lblInformation.Text, btn.Text, lblTime.Text, value));
                }
            }
        }
        //dùng để ẩn hiện lable điểm tích lũy của khách hàng thành viên
        private void ShowOrHideLablePoint()
        {
            if (chkCustomer.Checked == true)
            {
                pnCustomer.Visible = true;
            }
            else
            {
                pnCustomer.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn hủy tất cả những vé đã chọn ko?",
                "Hủy Mua Vé", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            foreach (Button btn in listSeatSelected)
            {
                btn.BackColor = Color.White;
            }
            RestoreDefault();
            this.OnLoad(new EventArgs());
        }

        private void RestoreDefault()
        {
            listSeatSelected.Clear();

            rdoAdult.Checked = true;
            grpLoaiVe.Enabled = false;
            chkCustomer.Checked = false;
            chkCustomer.Enabled = false;

            ShowOrHideLablePoint();

            total = 0;
            displayPrice = 0;
            discount = 0;
            payment = 0;
            plusPoint = 0;

            LoadBill();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (listSeatSelected.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn vé trước khi thanh toán!");
                return;
            }
            string message = "Bạn có chắc chắn mua những vé: \n";
            foreach (Button btn in listSeatSelected)
            {
                message += "[" + btn.Text + "] ";
            }
            message += "\nKhông?";
            DialogResult result = MessageBox.Show(message, "Hỏi Mua",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {

                int ret = 0;
                if (chkCustomer.Checked == true)
                {
                    foreach (Button btn in listSeatSelected)
                    {
                        Ticket ticket = btn.Tag as Ticket;

                        ret += TicketDAO.BuyTicket(ticket.ID, ticket.Type, customer.ID, ticket.Price);
                    }
					customer.Point += plusPoint;
					CustomerDAO.UpdatePointCustomer(customer.ID, customer.Point);
                }
                else
                {
                    foreach (Button btn in listSeatSelected)
                    {
                        Ticket ticket = btn.Tag as Ticket;

                        ret += TicketDAO.BuyTicket(ticket.ID, ticket.Type, ticket.Price);
                    }
                }
                if (ret == listSeatSelected.Count)
                {
                    MessageBox.Show("Bạn đã mua vé thành công!");
                }

                LoadListExpotingttk();

                //string resultttt = "";
                /*foreach (var pair in priceOfTicket)
                {
                    resultttt += $"Key: {pair.Key}, Value: {pair.Value}\n";
                }
                foreach (var item in listSeatSelected)
                {
                    resultttt += item.Text;
                }
                resultttt += "\n";
                foreach (var item in ListExportingtk.ExportingtkList)
                {
                    resultttt += $"ExportTime:{item.ExportTime} MovieName:{item.MovieName} SeatName:{item.SeatName} ShowTime:{item.ShowTime} TicketPrice:{item.TicketPrice} \n";
                }
                MessageBox.Show(resultttt);
                string n  = ListExportingtk.ExportingtkList.Count().ToString();
                MessageBox.Show(n);
                */

                // xử lý xuất vé
                //LoadListExpotingttk();
                foreach (Button btn in listSeatSelected)
                {
                    frmExportingtk frmExportingtk1 = new frmExportingtk();
                    frmExportingtk1.ShowDialog();
                    if (ListExportingtk.ExportingtkList.Count>0)
                    {
                        ListExportingtk.ExportingtkList.RemoveAt(0);
                    }
                }
            }
            priceOfTicket.Clear();
            RestoreDefault();
            this.OnLoad(new EventArgs());
        }

        private void rdoStudent_Click(object sender, EventArgs e)
        {
            if (rdoStudent.Checked == true)
            {
                if (listSeatSelected.Count == 0) return;
                Ticket ticket = listSeatSelected[listSeatSelected.Count - 1].Tag as Ticket;
                ticket.Type = 2;

                float oldPrice = ticket.Price;
                ticket.Price = 0.8f * ticketPrice;
                displayPrice = ticket.Price;
                total = total + ticket.Price - oldPrice;
                payment = total - discount;

                priceOfTicket.Remove(listSeatSelected[listSeatSelected.Count - 1].Text);
                priceOfTicket.Add(listSeatSelected[listSeatSelected.Count - 1].Text, displayPrice);
                LoadBill();
            }
        }

        private void rdoAdult_Click(object sender, EventArgs e)
        {
            if (rdoAdult.Checked == true)
            {
                if (listSeatSelected.Count == 0) return;
                Ticket ticket = listSeatSelected[listSeatSelected.Count - 1].Tag as Ticket;
                ticket.Type = 1;

                float oldPrice = ticket.Price;
                ticket.Price = ticketPrice;
                displayPrice = ticket.Price;
                total = total + ticket.Price - oldPrice;
                payment = total - discount;

                priceOfTicket.Remove(listSeatSelected[listSeatSelected.Count - 1].Text);
                priceOfTicket.Add(listSeatSelected[listSeatSelected.Count - 1].Text, displayPrice);

                LoadBill();
            }
        }

        private void rdoChild_Click(object sender, EventArgs e)
        {
            if (rdoChild.Checked == true)
            {
                if (listSeatSelected.Count == 0) return;
                Ticket ticket = listSeatSelected[listSeatSelected.Count - 1].Tag as Ticket;
                ticket.Type = 3;

                float oldPrice = ticket.Price;
                ticket.Price = 0.7f * ticketPrice;
                displayPrice = ticket.Price;
                total = total + ticket.Price - oldPrice;
                payment = total - discount;

                priceOfTicket.Remove(listSeatSelected[listSeatSelected.Count - 1].Text);
                priceOfTicket.Add(listSeatSelected[listSeatSelected.Count - 1].Text, displayPrice);

                LoadBill();
            }
        }

        private void chkCustomer_Click(object sender, EventArgs e)
        {
            if (chkCustomer.Checked == true)
            {
                frmCustomer frm = new frmCustomer();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    customer = frm.customer;
                    lblCustomerName.Text = customer.Name;
                    lblPoint.Text = customer.Point + "";
                    ShowOrHideLablePoint();
                }
                else
                {
                    chkCustomer.Checked = false;
                }
            }
            else
            {
                ShowOrHideLablePoint();
                customer = null;
            }
        }

        private void btnFreeTicket_Click(object sender, EventArgs e)
        {
            int freeTickets = (int)numericFreeTickets.Value;
            if (freeTickets <= 0) return;

            if (freeTickets > listSeat.Count)
            {
                MessageBox.Show("BẠN CHỈ ĐỔI ĐƯỢC TỐT ĐA [" + listSeatSelected.Count + "] VÉ", "THÔNG BÁO");
                return;
            }
            int pointFreeTicket = freeTickets * 20;
            if (customer.Point < pointFreeTicket)
            {
                MessageBox.Show("BẠN KHÔNG ĐỦ ĐIỂM TÍCH LŨY ĐỂ ĐỔI [" + freeTickets + "] VÉ", "THÔNG BÁO");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("BẠN CÓ MUỐN DÙNG ĐIỂM TÍCH LŨY ĐỂ ĐỔI [" + freeTickets + "] VÉ MIỄN PHÍ KHÔNG?",
                                        "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    customer.Point -= pointFreeTicket;
                    plusPoint -= freeTickets;

                    if (CustomerDAO.UpdatePointCustomer(customer.ID, customer.Point))
                    {
                        MessageBox.Show("BẠN ĐÃ DỔI ĐƯỢC [" + freeTickets + "] VÉ MIỄN PHÍ THÀNH CÔNG", "THÔNG BÁO");
                    }
                    lblPoint.Text = "" + customer.Point;
                    lblPlusPoint.Text = "" + plusPoint;

                    for (int i = 0; i < listSeatSelected.Count && freeTickets > 0; i++)
                    {
                        Ticket ticket = listSeatSelected[i].Tag as Ticket;
                        if (ticket.Price != 0)
                        {
                            discount += ticket.Price;
                            ticket.Price = 0;
                            freeTickets--;
                        }
                    }

                    payment = total - discount;
                    LoadBill();
                }
            }
        }

        private void flpSeat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPayment_Click(object sender, EventArgs e)
        {

        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkCustomer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblInformation_Click(object sender, EventArgs e)
        {

        }
    }
}
