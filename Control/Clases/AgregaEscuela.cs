using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Entidades;
using Datos.Modelos;

namespace Control.Clases
{
    public class AgregaEscuela
    {
        public string InsertaEscuela(string strClave,string strNombre, string strDireccion )
        {
            try
            {
                using (SistemaPruebaEntities objConect = new SistemaPruebaEntities())
                {
                    Escuela objEscuela = new Escuela
                    {
                        Clave = strClave,
                        Nombre = strNombre,
                        DIreccion = strDireccion
                    };

                    objConect.Escuela.Add(objEscuela);
                    objConect.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return "Registro agregado el registro con éxito";
        }

        public string ModificarEscuela(string strClave, string strNombre, string strDireccion)
        {
            try
            {
                using (SistemaPruebaEntities objConect = new SistemaPruebaEntities())
                {
                    Escuela objEscuela = (from q in objConect.Escuela where q.Clave == strClave select q).First();
                    objEscuela.Nombre = strNombre;
                    objEscuela.DIreccion = strDireccion;
                    objConect.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return "Registro actualizó el registro con éxito";
        }

        public string EliminaEscuela(string strClave)
        {
            try
            {
                using (SistemaPruebaEntities objConect = new SistemaPruebaEntities())
                {
                    Escuela objEscuela = (from q in objConect.Escuela where q.Clave == strClave select q).First();
                    objConect.Escuela.Remove(objEscuela);
                    objConect.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return "Registro eliminó el registro con éxito";
        }

        public List<ListaEscuelas> ConsultaEscuelas()
        {
            try
            {
                using (SistemaPruebaEntities objConect = new SistemaPruebaEntities())
                {
                    List<ListaEscuelas> objLista = (from q in objConect.Escuela
                                                    select new ListaEscuelas
                                                    {
                                                        Clave = q.Clave,
                                                        Nombre = q.Nombre,
                                                        Direccion = q.DIreccion
                                                    }).ToList();

                    return objLista;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
} 
