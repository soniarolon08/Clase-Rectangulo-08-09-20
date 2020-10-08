
public class Rectangulo{

    #region Atributos

        private int Base;

        private int Altura;

        private double Area;

        private double Perimetro;

    #endregion

    #region Constructores

        public Rectangulo(){
            this.Base = 0;
            this.Altura = 0;
        }
        public Rectangulo(int valor, int valor_2){
            this.Base = valor;
            this.Altura = valor_2;
        }

    #endregion

    #region Getters y Setters

        //Set
        public void SetBase(int valor){
            this.Base = valor;
        }
        public void SetAltura(int valor){
            this.Altura = valor;
        }
        public void SetPerimetro(int valor){
            this.Perimetro = valor;
        }
        public void SetArea(int valor){
            this.Area = valor;
        }
        //Get 
        public int GetBase(){
            return this.Base;
        }
        public int GetAltura(){
            return this.Altura;
        }
        public int GetArea(){
            return this.Area;
        }
        public int GetPerimetro(){
            return this.Perimetro;
        }

    #endregion
    

    #region Metodos

        public double calcularPerimetro(){
            return Base + Base + Altura + Altura;
        }
        public double calcuarArea(){
            return Base * Altura;
        }
        
    #endregion
}   