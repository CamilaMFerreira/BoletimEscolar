using System;
using System.Collections.Generic;
using LiteDB;
namespace Banco
{
    class Program
    {
        public class Banco<T>
        {

            private const string caminho = @"C:\Users\camila.ferreira\source\repos\BoletimEscolar";
            private const string arquivoNome = "BancoBoletim.db";
            public List<T> Listar()
            {
                using (var db = new LiteDatabase(caminho + arquivoNome))
                {
                    return db.GetCollection<T>().FindAll().ToList();
                }
            }

            public bool Add(T obj)
            {
                using (var db = new LiteDatabase(caminho + arquivoNome))
                {
                    try
                    {
                        db.GetCollection<T>().Insert(obj);

                    }
                    catch (System.Exception)
                    {

                        return false;
                    }
                    return true;
                }

            }

            public void Remove()
            {
                using (var db = new LiteDatabase(caminho + arquivoNome))
                {
                     
                }

            }
        }
