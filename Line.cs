class Line {
    //Class vars / fields
    private Point _p0;
    private Point _p1;
    private decimal _slope;
    private decimal _midpoint;

    //Properties
    //Accessors
    public Point P0 
    {
        get {
            return _p0;
        }
        set {
            _p0 = value;
        }
    }

    public Point P1 {
        get {
            return _p1;
        }
        set {
            _p1 = value;
        }
    }

    public decimal GetSlope() {
        return _slope;
    }

    public decimal GetMidpoint() {
        return _midpoint;
    }
    
    //Constructors
    public Line(Point point1, Point point2) {
        P0 = point1;
        P1 = point2;
    }

    public Line() {

    }


    public Line(int x1, int y1, int x2, int y2) {

        Point point1 = new(x1, y1);
        Point point2 = new(x2, y2);

        _p0 = point1;
        _p1 = point2;

    }

    //Methods
    public void Draw() {
        bool parser;

        decimal steps;

        int dx = P1.X - P0.X;
        int dy = P1.Y - P0.Y;
        //decimal slope = dy / dx;

        //_slope = slope;

        if (Math.Abs(dx) > Math.Abs(dy)) {
            steps = Math.Abs(dx);
        } else {
            steps = Math.Abs(dy);
        }

        decimal xInc = dx / steps;
        decimal yInc = dy / steps;

        
        //Console.WriteLine($"Slope: {Math.Abs(xInc)}:{Math.Abs(yInc)}");
        decimal X0 = P0.X;
        decimal Y0 = P0.Y;

        for (int step = 0; step <= steps; step++) {
            Point currentPoint = new((int)X0, (int)Y0);

            Console.SetCursorPosition(currentPoint.X, currentPoint.Y);
            currentPoint.DrawPoint();

            X0 += xInc;
            Y0 += yInc;
        }
    }

    public Line Perturb(int xmin, int xmax, int ymin, int ymax) {
        Line pertLine = new Line();
        Random rand = new Random();

        int perturbX0 = rand.Next(xmin, xmax + 1);
        int perturbY0 = rand.Next(ymin, ymax + 1);
        Point pertPoint0 = new Point(perturbX0, perturbY0);

        int perturbX1 = rand.Next(xmin, xmax + 1);
        int perturbY1 = rand.Next(ymin, ymax + 1);
        Point pertPoint1 = new Point(perturbX1, perturbY1);

        pertLine = new(pertPoint0, pertPoint1);

        return pertLine;
    }

    public void Collapse() {
        

    }

}//end class