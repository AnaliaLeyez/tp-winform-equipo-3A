﻿using Business;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpWinForms
{
    public partial class FormArticles : Form
    {
        List<Article> articlelist;
        public FormArticles()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BusinessArticle business = new BusinessArticle();
            List<Article> articlelist = new List<Article>();

            try
            {
                articlelist = business.list();
                dgvArticles.DataSource = articlelist;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void FormArticle_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid() {
        BusinessArticle business = new BusinessArticle();

            try
            {
                articlelist = business.list();
                dgvArticles.DataSource = articlelist;

             //   Article selected = (Article)dgvArticles.CurrentRow.DataBoundItem;
             //   LoadImg(selected.UrlImage[0]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LoadImg(string imagen)
        {
            try
            {
                pboxImg.Load(imagen);
            }
            catch (Exception ex)
            {
                pboxImg.Load("https://faculty.eng.ufl.edu/elliot-douglas/wp-content/uploads/sites/70/2015/11/img-placeholder.png");
            }
        }

        private void dgvArticles_SelectionChanged(object sender, EventArgs e)
        {
            Article selected = (Article)dgvArticles.CurrentRow.DataBoundItem;
            LoadImg(selected.UrlImage[0]);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormNewArticle form = new FormNewArticle();
            form.ShowDialog();
            LoadGrid();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Article art = (Article)dgvArticles.CurrentRow.DataBoundItem;
            FormNewArticle form = new FormNewArticle(art);
            form.ShowDialog();
            LoadGrid();
        }
    }
}
