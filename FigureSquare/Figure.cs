namespace FigureSquare
{
    public class Figure
    {
        //Enum of figureTypes to easily add new figures
        enum figureType
        {
            Triangle = 0,
            Circle = 1,
        }
        uint side1;
        uint side2;
        uint side3;
        figureType thisFigureType;
        //Base constructor is Circle with radius 1
        public Figure()
        {
            side1 = 1;
            thisFigureType = figureType.Circle;
        }
        //Triangle constructor
        public Figure(uint side1, uint side2, uint side3)
        {
            try
            {
                if ((side1 + side2 > side3) && (side2 + side3 > side1) && (side3 + side1 > side2))
                {
                    this.side1 = side1;
                    this.side2 = side2;
                    this.side3 = side3;
                    thisFigureType = figureType.Triangle;
                }
                else
                {
                    this.side1 = 3;
                    this.side2 = 4;
                    this.side3 = 5;
                    throw new Exception("No such triangle! Created triangle 3 4 5");
                }
            }
            catch(Exception e){Console.WriteLine(e.ToString());}
        }
        //Circleconstructor
        public Figure(uint Radius)
        {
            side1 = Radius;
            thisFigureType = figureType.Circle;
        }
        public double Square()
        {
            double answer = 0;
            try
            {
                switch (thisFigureType)
                {
                    case figureType.Triangle:
                        double halfPerimeter = (side1 + side2 + side3)/2;
                        answer = Math.Sqrt(halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));
                        break;
                    case figureType.Circle:
                        answer = Math.PI * Math.Sqrt(side1);
                        break;
                }
            }
            catch(Exception e) { Console.WriteLine(e.ToString()); }
            return answer;
        }
        public bool RightTriangle()
        { 
            bool answer = false;
            try
            {
                if (thisFigureType != figureType.Triangle)
                    throw new Exception("This is not a triangle!");
                else
                {
                    //Finding longest side
                    if (side1 > side2)
                    {
                        if (side1 > side3)
                        {
                            if (Math.Pow(side1, 2) == (Math.Pow(side2, 2) + Math.Pow(side3, 2)))
                                answer = true;
                        }
                        else
                        {
                            if (Math.Pow(side3,2) == (Math.Pow(side2,2) + Math.Pow(side1, 2)))
                                answer = true;
                        }
                    }
                    else
                    {
                        if (side2 > side3)
                        {
                            if (Math.Pow(side2,2) == (Math.Pow(side1,2) + Math.Pow(side3,2)))
                                answer = true;
                        }
                        else
                        {
                            if (Math.Pow(side3,2) == (Math.Pow(side2,2) + Math.Pow(side1,2)))
                                answer = true;
                        }
                    }
                }
            }
            catch(Exception e) { Console.WriteLine(e.ToString()); }
            return answer;
        }
    }
}