using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Net.Mail;
using System.Net;

namespace Modelo
{
    public class Producto
    {
        private int codigo;
        private string marca;
        private string nombre;
        private int stock;
        private decimal preciounitario;

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string Marca { get { return marca; } set { marca = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Stock { get { return stock; } set { stock = value; } } //{ get => stock; private set => stock = value; }
        public decimal PrecioUnitario { get { return preciounitario; } set { preciounitario = value; } }

        public Producto()
        {
            
        }
        public void ActualizarStock(int cantidad)
        {
            if (this != null)
            {
                // Actualiza el stock del producto.
                this.Stock -= cantidad;
            }
        }      
    }
}