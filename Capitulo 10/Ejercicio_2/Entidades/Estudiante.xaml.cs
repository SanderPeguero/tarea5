
namespace Ejercicio_2.Entidades{

    public class Estudiante{
        public string nombre;
        public int edad;
        public int curso;
        
        Estudiante(string nombre, int edad){
            
            nombre = this.nombre;
            edad = this.edad;
            
        }

        public void SetCurso(int curso){
            curso = this.curso;
        }

        public void SetEdad(int edad){
            edad = this.edad;
        }

    }

}