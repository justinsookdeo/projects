using System;

namespace Project1{
  class Program{
    static void Main(string[] args){
     while (true){
      Console.WriteLine("Please enter a watertank name cube/cuboid/cylinder:");
      string tank = Console.ReadLine();
      if (tank == "cube"){
         Console.WriteLine("Please enter the side of a cube:");
         int side = Convert.ToInt32(Console.ReadLine());
         cube c = new cube(side);
         c.volume();
      }
      else if (tank == "cuboid"){
              Console.WriteLine("Please enter the length of a cuboid:");
              int lenght = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Please enter the breath of a cuboid:");
              int breath = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Please enter the height of a cuboid:");
              int height = Convert.ToInt32(Console.ReadLine());
              cuboid cu = new cuboid(lenght, breath, height);
              cu.volume();
      }
      else if (tank == "cylinder"){
              Console.WriteLine("Please enter the radius of a cylinder:");
              double radius = Convert.ToDouble(Console.ReadLine());
              Console.WriteLine("Please enter the height of a cylinder:");
              double height = Convert.ToDouble(Console.ReadLine());
              cylinder cy = new cylinder(radius, height);
              cy.volume();
      }
      else{
          Console.WriteLine("Please enter a valid option");
      }
     }
     Console.ReadKey();
    }
    public interface watertank{
       public void volume();
    }
    public class cube : watertank{
       private int side;
       public cube(int s){
         side=s;
       }
       public void volume(){
         int vol = side*side*side;
         Console.WriteLine("The volume of the cube is:{0}",vol);
         Console.WriteLine("");
       }
    }
    public class cuboid : watertank{
       private int length;
       private int breath;
       private int height;
       public cuboid(int l,int b,int h){
         length=l;
         breath=b;
         height=h;
       }
       public void volume(){
         int vol = length*breath*height;
         Console.WriteLine("The volume of the cuboid is:{0}",vol);
         Console.WriteLine("");
       }
    }
    public class cylinder : watertank{
       private double radius;
       private double height;
       double pi=3.14;
       public cylinder(double r,double h){
         radius=r;
         height=h;
       }
       public void volume(){
         double vol = pi*radius*radius*height;
         Console.WriteLine("The volume of the cylinder is:{0}",vol);
         Console.WriteLine("");
       }
    }
  }
}
