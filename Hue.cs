class Hue {
    private byte _red;
    private byte _grn;
    private byte _blu;

    //Properties
    public byte R {
        get {
            return _red;
        }
        set {
            _red = value;
        }
    }

    public byte G {
        get {
            return _grn;
        }
        set {
            _grn = value;
        }
    }

    public byte B {
        get {
            return _blu;
        }
        set {
            _blu = value;
        }
    }

    //Constructors
    public Hue() {
    }

    public Hue(byte redLevel, byte grnLevel, byte bluLevel) {
        SetHue(redLevel, grnLevel, bluLevel);
    }

    public void SetHue(byte redLevel, byte grnLevel, byte bluLevel) {
        _red = redLevel;
        _grn = grnLevel;
        _blu = bluLevel;
    }

    //Accessor
    //public byte GetRed() {
    //    return _red;
    //}
    //
    ////Mutator
    //public void SetRed(byte newRed) {
    //    _red = newRed;
    //}
}   
