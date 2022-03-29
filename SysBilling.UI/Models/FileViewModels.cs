namespace SysBilling.UI.Models

{
    public class FileViewModels
    {
      public  string name { get; set; }
        public string? path { get; set; }
        public IFormFile File { get; set; }


      public static string SaveFile(IFormFile file)
        {

            FileViewModels fileviewmodel = new FileViewModels();
            //renombrar el archivo
            fileviewmodel.name = Guid.NewGuid().ToString() + file.FileName;
            fileviewmodel.path = Path.Combine(Directory.GetCurrentDirectory() + "\\wwwroot\\img" 
                + fileviewmodel.name);

            //guardar la immage en la carpeta img

            using var stream = new FileStream(fileviewmodel.path, FileMode.Create);
            file.CopyTo(stream);
            //guardar la ruta relativa del archivo en sql


            //retornar la ruta relativa del archivo
            return "..\\img\\" + fileviewmodel.name;



        }
    }



}
