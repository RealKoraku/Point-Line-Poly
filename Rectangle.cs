using System.ComponentModel.DataAnnotations;

class Rectangle {
    //Fields
    private Line[] _lines = new Line[4];
    private int _area = 0;

    public int Area {
        get {
            return _area;
        }
    }

    public Rectangle(int x, int y, int length, int width) {
        _area = length * width;

        Point topLeft = new(x, y);
        Point topRight = new(x, y + width);
        Point btmLeft = new(x + length, y);
        Point btmRight = new(x + length, y + width);

        _lines[0] = new(topLeft, topRight);
        _lines[1] = new(topLeft, btmLeft);
        _lines[2] = new(btmLeft, btmRight);
        _lines[3] = new(topRight, btmRight);
    }

    public Rectangle(Point p0, int length, int width) {
        _area = length * width;

        Point topLeft = p0;
        Point topRight = new(p0.X, p0.Y + width);
        Point btmLeft = new(p0.X + length, p0.Y);
        Point btmRight = new(p0.X + length, p0.Y + width);

        _lines[0] = new(topLeft, topRight);
        _lines[1] = new(topLeft, btmLeft);
        _lines[2] = new(btmLeft, btmRight);
        _lines[3] = new(topRight, btmRight);

    }

    public Rectangle(Point p0, Point p1, Point p2, Point p3) {

        Point topLeft = p0;
        Point topRight = p1;
        Point btmLeft = p2;
        Point btmRight = p3;

        _lines[0] = new(p0, p1);
        _lines[1] = new(p0, p2);
        _lines[2] = new(p2, p3);
        _lines[3] = new(p1, p3);

        int width = p1.X - p0.X;
        int length = p2.Y - p0.Y;

        _area = length * width;
    }

    public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4) {
        Point topLeft = new(x1, y1);
        Point topRight = new(x2, y2);
        Point btmLeft = new(x3, y3);
        Point btmRight = new(x4, y4);

        _lines[0] = new(topLeft, topRight);
        _lines[1] = new(topLeft, btmLeft);
        _lines[2] = new(btmLeft, btmRight);
        _lines[3] = new(topRight, btmRight);

        int width = topRight.X - topLeft.X;
        int length = btmLeft.Y - topLeft.Y;

        _area = length * width;
    }

    public void Move(int newX, int newY) {
        int width = _lines[0].P1.X - _lines[0].P0.X;
        int length = _lines[1].P1.Y - _lines[1].P0.Y;

        Point topLeft = new(newX, newY);
        Point topRight = new(newX + width, newY);
        Point btmLeft = new(newX, newY + length);
        Point btmRight = new(newX + width, newY + length);

        _lines[0] = new(topLeft, topRight);
        _lines[1] = new(topLeft, btmLeft);
        _lines[2] = new(btmLeft, btmRight);
        _lines[3] = new(topRight, btmRight);
    }

    public void Reform(int x1, int y1, int length, int width) {
        int newArea = length * width;
        _area = newArea;

        int x2 = x1 + length;
        int y2 = y1 + width;
        int x3 = x1 + length;
        int y3 = y1 + width;
        int x4 = x1 + length;
        int y4 = y1 + width;

        Point newTopLeft = new(x1, y1);
        Point newTopRight = new(x2, y2);
        Point newBtmLeft = new(x3, y3);
        Point newBtmRight = new(x4, y4);

        _lines[0] = new(newTopLeft, newTopRight);
        _lines[1] = new(newTopLeft, newBtmLeft);
        _lines[2] = new(newBtmLeft, newBtmRight);
        _lines[3] = new(newBtmRight, newTopRight);
    }

    public void Reform(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4) {
        Point newTopLeft = new(x1, y1);
        Point newTopRight = new(x2, y2);
        Point newBtmLeft = new(x3, y3);
        Point newBtmRight = new(x4, y4);

        _lines[0] = new(newTopLeft, newTopRight);
        _lines[1] = new(newTopLeft, newBtmLeft);
        _lines[2] = new(newBtmLeft, newBtmRight);
        _lines[3] = new(newBtmRight, newTopRight);
    }

    public void Draw() {

        for (int line = 0; line < _lines.Length; line++) {
            Console.SetCursorPosition(_lines[line].P0.X, _lines[line].P0.Y);

            _lines[line].Draw();

            //    if (line % 2 < 1) {
            //        xAxis = true;
            //    } else {
            //        xAxis = false;
            //    }
            //
            //    int xSteps = _lines[line].P1.X - _lines[line].P0.X;
            //    int ySteps = _lines[line].P1.Y - _lines[line].P0.Y;
            //
            //    if (xAxis) {
            //
            //        for (int point = 0; point < xSteps; point++) {
            //
            //            Console.SetCursorPosition(_lines[line].P0.X + point, _lines[line].P0.Y);
            //            Console.Write("*");
            //        }
            //
            //    } else {
            //        for (int point = 0; point < ySteps + 1; point++) {
            //
            //            Console.SetCursorPosition(_lines[line].P0.X, _lines[line].P0.Y + point);
            //            Console.Write("*");
            //        }
            //    }
            //}
        }
    }
}