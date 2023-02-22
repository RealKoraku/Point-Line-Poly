class GenericLinkedList<T> {
    private Node _head = null;
    private int _count = 0;

    public int Count {
        get { return _count; }
        private set { _count = value; }
    }//end property

    public object Get(int index) {
        //SAFETY CHECKS
        if (index >= Count || index < 0) {
            throw new IndexOutOfRangeException($"Index is outside the bounds of the LinkedList. List is {Count} in size. index is currently {index}");
        }//end if 

        //REFRENCE HEAD OF LIST
        Node currentNode = _head;
        int currentIndex = 0;

        //LOOP UNTIL END WE REACH THE INDEX
        while (currentIndex < index) {
            currentNode = currentNode.Next;
            currentIndex += 1;
        }//end while

        //RETURN DATA
        return currentNode.Data;
    }//end method

    public void Set(int index, object element) {

        Node currentNode = _head;

        if (index >= Count || index < 0) {
            throw new IndexOutOfRangeException($"Index is outside the bounds of the LinkedList. List is {Count} in size. index is currently {index}");
        }

        for (int currentIndex = 0; currentIndex < Count; currentIndex++) {

            if (currentIndex == index) {
                currentNode.Data = element;
            }

            currentNode = currentNode.Next;
        }
    }//end function

    public object this[int index] {
        get { return Get(index); }
        set { Set(index, value); }
    }//end indexer
}

//    public int Count {
//        get { return _count; }
//        private set { _count = value; }
//    }//end property

//    public GenericLinkedList() {
//    }

//    public void Add(object value) {
//        //CREATE NEW NODE & FILL ITS DATA
//        Node newNode = new Node(value);

//        if (_head == null) {
//            _head = newNode;
//        } else {
//            //REFRENCE HEAD OF LIST
//            Node currentNode = _head;

//            //LOOP UNTIL END OF LIST
//            while (currentNode.Next != null) {
//                currentNode = currentNode.Next;
//            }//end while

//            //ADD NEW NODE TO END OF LIST
//            currentNode.Next = newNode;
//        }//end if

//        Count += 1;
//    }//end method

//    public object Get(int index) {
//        //SAFETY CHECKS
//        if (index >= Count || index < 0) {
//            throw new IndexOutOfRangeException($"Index is outside the bounds of the LinkedList. List is {Count} in size. index is currently {index}");
//        }//end if 

//        //REFRENCE HEAD OF LIST
//        Node currentNode = _head;
//        int currentIndex = 0;

//        //LOOP UNTIL END WE REACH THE INDEX
//        while (currentIndex < index) {
//            currentNode = currentNode.Next;
//            currentIndex += 1;
//        }//end while

//        //RETURN DATA
//        return currentNode.Data;
//    }//end method

//    public void Set(int index, object element) {

//        Node currentNode = _head;

//        if (index >= Count || index < 0) {
//            throw new IndexOutOfRangeException($"Index is outside the bounds of the LinkedList. List is {Count} in size. index is currently {index}");
//        }

//        for (int currentIndex = 0; currentIndex < Count; currentIndex++) {

//            if (currentIndex == index) {
//                currentNode.Data = element;
//            }

//            currentNode = currentNode.Next;
//        }
//    }//end function

//    public object this[int index] {
//        get { return Get(index); }
//        set { Set(index, value); }
//    }//end indexer

//    public void AddFirst(object element) {
//        Node currentNode = _head;
//        Node newNode = new Node(element);

//        _head = newNode;
//        newNode.Next = currentNode;

//        Count++;

//    }

//    public void Clear() {
//        Node currentNode = new Node(null);
//        _head = currentNode;

//        for (int currentIndex = 0; currentIndex < Count; currentIndex++) {
//            currentNode = new Node(null);
//        }
//        Count = 0;
//    }

//    public bool Contains(object element) {
//        bool contains = false;
//        Node currentNode = _head;
//        Node elementNode = new Node(element);

//        for (int currentIndex = 0; currentIndex < Count; currentIndex++) {

//            if (currentNode.Data.Equals(elementNode.Data)) {
//                return contains = true;
//            }
//            currentNode = currentNode.Next;

//        }
//        return contains;
//    }

//    public object GetFirst() {

//        Node currentNode = _head;

//        if (Count == 0) {
//            throw new IndexOutOfRangeException($"Index is outside the bounds of the LinkedList. List is {Count} in size.");
//        }//end if 

//        return currentNode.Data;
//    }

//    public object GetLast() {
//        Node currentNode = _head;

//        if (Count == 0) {
//            throw new IndexOutOfRangeException($"Index is outside the bounds of the LinkedList. List is {Count} in size.");
//        }//end if 

//        for (int currentIndex = 0; currentIndex < Count; currentIndex++) {
//            currentNode = currentNode.Next;

//            if (currentIndex == Count) {
//                return currentNode.Data;
//            }
//        }
//        return currentNode.Data;
//    }

//    public int IndexOf(object element) {
//        Node currentNode = _head;
//        Node elementNode = new(element);

//        for (int currentIndex = 0; currentIndex < Count; currentIndex++) {
//            if (currentNode.Data.Equals(elementNode.Data)) {
//                return currentIndex;

//            } else if (currentIndex == Count) {
//                return -1;

//            } else {
//                currentNode = currentNode.Next;
//            }
//        }
//        return -1;
//    }

//    public int GetCountOf(object element) {
//        Node currentNode = _head;
//        Node elementNode = new(element);
//        int elementCount = 0;

//        for (int currentIndex = 0; currentIndex < Count; currentIndex++) {
//            if (currentNode.Data.Equals(elementNode.Data)) {
//                elementCount++;
//            } else if (currentIndex == Count && elementCount == 0) {
//                return -1;
//            }
//            currentNode = currentNode.Next;
//        }
//        if (elementCount == 0) {
//            return -1;
//        } else {
//            return elementCount;
//        }
//    }

//    public object RemoveFirst() {

//        if (Count == 0) {
//            throw new IndexOutOfRangeException($"Index is outside the bounds of the LinkedList. List is {Count} in size.");
//            return null;
//        }//end if 

//        Node currentNode = _head;
//        currentNode = currentNode.Next;
//        _head = currentNode;

//        Count--;

//        return currentNode;
//    }

//    public object RemoveLast() {
//        Node currentNode = _head;

//        Node lastNode = new();

//        if (Count == 0) {
//            throw new IndexOutOfRangeException($"Index is outside the bounds of the LinkedList. List is {Count} in size.");
//            return null;
//        }//end if 

//        for (int currentIndex = 0; currentIndex < Count; currentIndex++) {
//            if (currentNode.Next != null) {
//                lastNode = new(currentNode);
//                currentNode = currentNode.Next;
//            } else {
//                lastNode = new(currentNode);
//                currentNode.Data = null;
//            }
//        }
//        Count--;
//        return lastNode;
//    }

//    public bool RemoveValue(object element) {
//        Node currentNode = _head;
//        Node elementNode = new(element);

//        for (int currentIndex = 0; currentIndex < Count; currentIndex++) {
//            if (currentNode.Data.Equals(elementNode.Data)) {
//                currentNode.Data = currentNode.Next;
//                Count--;
//                return true;
//            }
//        }
//        return false;
//    }
//    public object[] ToArray() {
//        Node currentNode = _head;
//        object[] list = new object[Count];

//        for (int i = 0; i < Count; i++) {
//            list[i] = currentNode.Data;
//            currentNode = currentNode.Next;
//        }
//        return list;
//    }

//    public int Counts() {
//        Node currentNode = _head;
//        int count = 0;

//        for (int i = 0; i < Count; i++) {
//            currentNode = currentNode.Next;
//            count++;
//        }
//        return count;
//    }
//}