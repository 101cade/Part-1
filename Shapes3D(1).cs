using Shapes;

namespace Shapes3d
{
    public abstract class Shape3D
    {
        public abstract double GetSurfaceArea();
        public abstract double GetVolume();
    }


    // First Shape: Cuboid
    class Cuboid : Shape3D
    {
        public double depth;
        public double width;
        public double height;

        public Cuboid(double depth, double width, double height)
        {
            this.width = width;
            this.height = height;
            this.depth = depth; 
        }
   

        // surface area of a cuboid: 2(lh + lw + hw)
        // https://byjus.com/maths/surface-area-of-cuboid/
        override public double GetSurfaceArea()
        {
            return (2*(this.depth*this.height)+ 2*(this.depth*this.width)+ 2*(this.height*this.width));
        }

        // Volume of a cuboid: l * b * h
        // https://byjus.com/maths/volume-of-cuboid/
        override public double GetVolume()
        {
            return this.depth * this.width * this.height;
        }
    
   
   
    }

    // Second shape: Cube
    class Cube : Cuboid 
    {
        public Cube(double length) : base(
           
            width : length,
            height : length,
            depth : length) {}

        
        
        
    }
    // Third shape: Cylinder
    class Cylinder : Shape3D
    {
        public double radius;
        public double height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }
   
        // Surface Area of a Cylinder: 2 * pi * r * h + 2 * pi * r * r * r
        override public double GetSurfaceArea()
        {
            return (2*(Math.PI * this.radius * this.height) + 2*(Math.PI * this.radius * this.radius * this.radius));
        }

        // Volume of a Cylinder: pi * r * r * r * h
        override public double GetVolume()
        {
            return Math.PI * this.radius * this.radius * this.radius * this.height;
        }
   
   
   
   
   
    }
    // Fourth Shape: Sphere
    class Sphere : Shape3D
    {
        public double radius;

        public Sphere(double radius)
        {
            this.radius = radius; 
        }

        //Surface area of a sphere: 4 * pi * r * r * r
        public override double GetSurfaceArea()
        {
            return (4*(Math.PI * this.radius * this.radius * this.radius));
        }

        // Volume of a sphere: 4/3 * pi * r * r * r * r
        public override double GetVolume()
        {
            return (4.0/3.0*(Math.PI * this.radius * this.radius * this.radius * this.radius));
        }

    }
   
    // Fifth Shape: Prism
    class Prism : Shape3D
    {
        public double sideLength;
        int faces;
        double height;

        public Prism(double sideLength, int faces, double height)
        {
            this.sideLength = sideLength;
            this.faces = faces;
            this.height = height;
        }
   

        // Surface Area of a Prism: 2 * B + P * H
        public override double GetSurfaceArea()
        {
            return (2*(this.faces) + (this.sideLength * this.height));
        }
   
       
        // Volume of a Prism: B * H
        public override double GetVolume()
        {
            return this.faces * this.height;
        }
   
    }


}
