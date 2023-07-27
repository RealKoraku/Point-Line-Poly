class Polygon {

    private int _n = 0;
    private LinkedList _points;
    private Point _aPoint;
    private Line[] _lines;
    bool _closed;

    public LinkedList Points {
        get {
            return _points;
        }
        set {
            _points = value;
        }
    }



    public Polygon(LinkedList apoints) {
        _points = apoints;

        //CONVERT POINTS TO OBJECT ARRAY
        object[] tempPoints = _points.ToArray();

        //UPDATE NUM OF POINTS
        _n = tempPoints.Length;

        //CREATE ARRAY OF POINTS
        Point[] polyPoints = new Point[tempPoints.Length];


        for (int i = 0; i < _n; i++) {
            //STORE POINTS TO POINT ARRAY
            polyPoints[i] = (Point)tempPoints[i];
        }

        for (int i = 0; i < _n; i++) {

            if (polyPoints.Length == 1) {
                polyPoints[i].DrawPoint();

            } else if (i < polyPoints.Length-1) {
                Line aLine = new Line();

                aLine = new(polyPoints[i], polyPoints[i + 1]);
                aLine.Draw();

            } else {
                break;
            }
        }
    }

    public override string ToString() {

        string allPoints = "";

        for (int i = 0; i < _n; i++) {

            string pointX = _aPoint.X.ToString();
            string pointY = _aPoint.Y.ToString();

            string point = $"{pointX} ,{pointY}";

            allPoints = $"{allPoints} + {point}, ";
        }

        return allPoints;
    }
}
    //public Polygon(Point p0, Point p1, Point p2) {
    //    _n = 3;
    //    _lines = new Line[_n];
    //
    //    _lines[0] = new(p0, p1);
    //    _lines[1] = new(p1, p2);
    //    _lines[2] = new(p2, p0);
    //
    //    _lines[0].Draw();
    //    _lines[1].Draw();
    //    _lines[2].Draw();
    //}