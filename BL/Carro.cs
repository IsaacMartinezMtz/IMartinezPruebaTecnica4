using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Carro
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.IMartinezPruebaTecnica4Entities contex = new DL.IMartinezPruebaTecnica4Entities())
                {
                    var query = contex.GetAll().ToList();
                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var obj in query)
                        {
                            ML.Carro carro = new ML.Carro();
                            carro.IdCarro = obj.IdCarro;
                            carro.Marca = obj.Marca;
                            carro.Modelo = obj.Modelo;
                            carro.NumeroSerie = obj.NumeroSerie;
                            carro.Color = obj.Color;
                            carro.PaisOrigen = obj.PaisOrigen;
                            carro.Placa = obj.Placa;
                            result.Objects.Add(carro);
                        }
                        result.Correct=true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
                
            }catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
        public static ML.Result GetById(int idCarro)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.IMartinezPruebaTecnica4Entities context = new DL.IMartinezPruebaTecnica4Entities())
                {
                    var query = context.GetById(idCarro).FirstOrDefault();
                    result.Object = new List<object>();
                    if (query != null)
                    {
                        ML.Carro carro = new ML.Carro();
                        carro.IdCarro = query.IdCarro;
                        carro.Marca = query.Marca;
                        carro.Modelo = query.Modelo;
                        carro.NumeroSerie = query.NumeroSerie;
                        carro.Color = query.Color;
                        carro.PaisOrigen = query.PaisOrigen;
                        carro.Placa = query.Placa;

                        result.Object = carro;
                        result.Correct = true;
                    
                    }
                }
               
            }catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
        public static ML.Result Add(ML.Carro carro)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.IMartinezPruebaTecnica4Entities context = new DL.IMartinezPruebaTecnica4Entities())
                {
                    var query = context.CarroAdd(carro.Marca, carro.Modelo, carro.NumeroSerie, carro.Color, carro.PaisOrigen, carro.Placa);
                    if(query > 0)
                    {
                        result.Correct=true;
                    }
                    else
                    {
                        result.Correct=false;
                    }
                }

            }catch( Exception ex )
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;

        }
        public static ML.Result Upadate(ML.Carro carro)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.IMartinezPruebaTecnica4Entities context = new DL.IMartinezPruebaTecnica4Entities())
                {
                    var query = context.CarroUpdate(carro.IdCarro, carro.Marca, carro.Modelo, carro.NumeroSerie, carro.Color, carro.PaisOrigen, carro.Placa);
                    if(query > 0)
                    {
                        result.Correct = false;
                    }
                    else
                    {
                        result.Correct=false;  
                    }
                }

            }catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
        public static ML.Result Delete(int idCarro)
        {
            ML.Result result=new ML.Result();
            try
            {
                using(DL.IMartinezPruebaTecnica4Entities context = new DL.IMartinezPruebaTecnica4Entities())
                {
                    var query = context.eliminar(idCarro);
                    if(query >0)
                    {
                        result.Correct = false;
                    }
                    else
                    {
                        result.Correct=false;
                    }
                }
            }
            catch( Exception ex )
            {
                result.Correct= false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
    }
}