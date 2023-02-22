class Point {
    //Class variables (fields)
    private int _x;
    private int _y;
    private Hue _color;

    public int X { get { return _x; } set { _x = value;} }
    public int Y { get { return _y; } set { _y = value;} }
    

    //Property
    public Hue Color {
        get { return _color; }
        set { _color = value; }
    }
    //Constructor
    public Point(int initialX, int initialY) {
        _color = new Hue();
        _x = initialX;
        _y = initialY;
    }//End constructor

    //Public methods
    public void DrawPoint() {
        Console.SetCursorPosition(_x, _y);
        //SetMyColor();
        Console.Write("*");
        //Console.ResetColor();
    }

    public void SetColor(byte red, byte grn, byte blu) {
        Color.R = red;
        Color.G = grn;
        Color.B = blu;
    }//end method

    private void SetMyColor() {
        //Console.Write("\x1b[48;2;" + Color.R + ";" + Color.G + ";" + Color.B + "m");
        Console.Write("\x1b[38;2;" + Color.R + ";" + Color.G + ";" + Color.B + "m");
    }//end method
}