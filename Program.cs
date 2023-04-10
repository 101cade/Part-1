using Shapes3d;

namespace Solver 
{
    static class Solver
    {
        public static void Main(String[] args)
        {
            // Console.WriteLine("Hello");
            string filepath = args [0];
            double total = 0;
            List<Shape3D> cadenceList = new List<Shape3D>();

            foreach(string line in System.IO.File.ReadLines(filepath))
            {
                
                // Console.WriteLine(line);
                string [] lineData = line.Split(',');

                Shape3D myShape;
                // Console.WriteLine(line);
                switch (lineData[0]){
                     case "cuboid":
                        myShape = new Cuboid(
                            Convert.ToDouble(lineData[1]),
                            Convert.ToDouble(lineData[2]),
                            Convert.ToDouble(lineData[3])
                        );
                    break;

                    case "cube":
                        myShape = new Cube(
                            Convert.ToDouble(lineData[1])
                        );
                    break;

                    case "cylinder":
                        myShape = new Cylinder(
                            Convert.ToDouble(lineData[1]),
                            Convert.ToDouble(lineData[2])
                        );
                    break;

                    case "sphere":
                        myShape = new Sphere(
                            Convert.ToDouble(lineData[1])
                        );
                    break;

                    case "prism":
                        myShape = new Prism(
                            Convert.ToDouble(lineData[1]),
                            Convert.ToInt32(lineData[2]),
                            Convert.ToDouble(lineData[3])
                        );
                    break;
                
                    default:
                        throw new FormatException($"Unable to parse shape from name {lineData[0]}");
                
                    case "area":
                        foreach(Shape3D shape in cadenceList){
                            total += shape.GetSurfaceArea() * Convert.ToDouble(lineData[1]);
                        }
                        cadenceList.Clear();

                    continue;

                    case "volume":
                        foreach(Shape3D shape in cadenceList){
                            total += shape.GetVolume() * Convert.ToDouble(lineData[1]);
                        }
                        cadenceList.Clear();

                    continue;

                   
                }   

               

               
                
            }
                    
                    Console.WriteLine("The total is: " + total);
        
        
        }
               
    
    
    
    }
}