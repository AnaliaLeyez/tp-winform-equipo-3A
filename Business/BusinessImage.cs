﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessImage
    {
        public List<Image> list()
        {
            List<Image> list = new List<Image>();
            DataAccess data = new DataAccess();

            try
            {
                data.setQuery("select Id, IdArticulo, ImagenUrl from IMAGENES");
                data.executeRead();

                while (data.Reader.Read())
                {
                    Image aux = new Image();
                    aux.Id = (int)data.Reader["Id"];
                    aux.IdArticle = (int)data.Reader["IdArticulo"];
                    aux.UrlImage = (string)data.Reader["ImagenUrl"];

                    list.Add(aux);
                }
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.closeConnection();
            }
        }


        public void AddImage(List<string> images, int id)
        {
            DataAccess data = new DataAccess();

            try
            {
                foreach(var img in images)
                {
                    data.setQuery("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                    data.setParameter("@IdArticulo", id);
                    data.setParameter("@ImagenUrl", img);
                    data.executeAction();

                    data.clearParams();
                    data.closeConnection();
                    
                }


            }
            catch (Exception ex)
            {

                throw ex ;
            }
            finally
            {
                data.closeConnection();
            }
        }
    }
}
