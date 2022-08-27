namespace CodeFirst_example.Models {
    public class Domicilio : EntidadBase{
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
    }
}