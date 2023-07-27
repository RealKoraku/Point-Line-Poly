class GenericNode<T> {
    private T _data;
    private GenericNode<T> _next;

    public T Data {
        get { return _data; }
        set { _data = value; }
    }//end property

    public GenericNode<T> Next {
        get { return _next; }
        set { _next = value; }
    }//end property

    public GenericNode(T new_data) {
        _data = new_data;
    }//end constructor

    public GenericNode() {
        _data = default;
    }//end constructor
}//end class