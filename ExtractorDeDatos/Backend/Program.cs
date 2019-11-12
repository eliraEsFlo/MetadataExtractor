using Backend.Infrastructura.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class Program
    {
        public static void WorkWithData()
        {
            /*
           UnitOfWork unitOfWor = new UnitOfWork();

           unitOfWor.Requerimientos
               .ObtenerRequerimientoPorTipoAsignacion("Individual")
               .ToList()
               .ForEach(r => Console.WriteLine($"id: {r.idRequerimiento} name: {r.NombreRequerimiento} "));

           Console.WriteLine(unitOfWor.Requerimientos.ObtenerUltimoRequerimiento());

           unitOfWor.Requerimientos.ObtenerAreas()
               .ForEach(r => Console.WriteLine($"id: {r.idArea} name: {r.NombreArea} \n"));

           unitOfWor.Requerimientos.ObtenerTiposRequerimientos()
                 .ForEach(r => Console.WriteLine($"Tipos id: {r.idTipoRequerimiento} name: {r.NombreTipoRequerimiento} "));


           unitOfWor.Requerimientos.ObtenerProcesos()
               .ForEach(r => Console.WriteLine($"\n id: {r.idProceso} name: {r.NombreProceso} "));

           unitOfWor.Requerimientos.ObtenerPermisosDePU()
               .ForEach(r => Console.WriteLine($"\n id: {r.idPermisoPU} name: {r.NombrePermiso} "));

           List<Requerimientos> users = new List<Requerimientos>()
           {
               new Requerimientos(){idRequerimiento="sdf",NombreRequerimiento="fkjdfk"},
                  new Requerimientos(){idRequerimiento="2",NombreRequerimiento="dfgerrrrr"},
                     new Requerimientos(){idRequerimiento="3",NombreRequerimiento="dfgdfg"},
                        new Requerimientos(){idRequerimiento="4",NombreRequerimiento="fkjdfk"}
           }; 

           Requerimientos r = users.FirstOrDefault(u => u.idRequerimiento  == "4");

           var query = unitOfWor.Requerimientos.GetAll().Join(unitOfWor.PermisosPorRequerimiento.GetAll().ToList(),
             (idReq => idReq.idRequerimiento),   
             (or => or.idRequerimiento), 
             ((idReq, or) => new { Clients = idReq, Orders = or }));

           query.ToList().ForEach(q => Console.WriteLine(q.Clients));

           DoWorkAsyncInfiniteLoop(r);



            DirectoryInfo directoryInfo = new DirectoryInfo(filePath);

            
            Console.WriteLine(body);
            
             */

            
        }

        static List<Objeto> GetDataFromFile(DirectoryInfo directoryInfo, List<string> filters)
        {
            List<Objeto> objetos = new List<Objeto>();

            filters.ForEach(extensionFilter => {

                FileInfo[] fileInfo = directoryInfo.GetFiles($"*.{extensionFilter}");

                StringBuilder body = new StringBuilder();


                foreach (var info in fileInfo)
                {
                    objetos.Add(new Objeto()
                    {
                        NombreObjeto = info.Name,
                        FechaCreacion = info.CreationTime,
                        FechaModificacion = info.LastWriteTime,
                        TipoObjeto = info.Extension
                    });
                }
            });

            return objetos;
        }

        static void ExtraerMetadatos(string filePath)
        {
            DirectoryInfo info = new DirectoryInfo(filePath);
            StringBuilder body = new StringBuilder();
            List<string> filtros = new List<string>() {
                "cs","config"
            };
            List<Objeto> objetos = GetDataFromFile(info, filtros);
            objetos.ForEach(ob =>
            {
                Console.WriteLine($"--->Objeto: {ob.NombreObjeto} \n \t\t -> Creacion: {ob.FechaModificacion} \n \t\t " +
                    $"<- UltimaModificacion:{ob.FechaModificacion} \n \t\t & Tipo objeto:{ob.TipoObjeto}");
            });

            Console.WriteLine($"\t # Cantidad de objetos {objetos.Count}");
        }
        static void Main(string[] args)
        {
            string root = @"C:\Users\Ariel\Documents\GitHub\RazorWebForm\RequerimientosPro\Backend\Infrastructura\Interfaces";
            DirectoryInfo info = new DirectoryInfo(root);
            StringBuilder body = new StringBuilder();
            body.AppendLine($"Nombre: {info.Name}");
            body.AppendLine($"fecha modificacion: {info.LastWriteTime}");
            body.AppendLine($"ultima vista: { info.LastAccessTime}");
            Console.WriteLine(body.ToString());

            RecorrerDirectorios(root);
            

            Console.ReadKey();
        }
        private static string RecorrerDirectorios(string directorioPrincipal)

        {
            Console.WriteLine($"Carpeta: {directorioPrincipal}");
          
            string[] subDirectoriosEntrantes = Directory.GetDirectories(directorioPrincipal);
            List<string> subDirectorios = new List<string>(subDirectoriosEntrantes);
            ExtraerMetadatos(directorioPrincipal);
            subDirectorios.ForEach(directorio => ExtraerMetadatos(RecorrerDirectorios(directorio)));

            return directorioPrincipal;
        }



        private static async Task DoWorkAsyncInfiniteLoop(Requerimientos re)
        {
            bool isRunning = true;
            while (isRunning)
            {
                // do the work in the loop
                string newData = DateTime.Now.ToLongTimeString();
                re.idRequerimiento = newData;
                // update the UI
                Console.WriteLine(re.idRequerimiento);

                // don't run again for at least 200 milliseconds
                await Task.Delay(200);
            }
        }
    }
}
