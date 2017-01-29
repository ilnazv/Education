namespace Algorithms.PieProgress
{
    class Node
    {
        private int nodeItem;
        public Node(int value)
        { nodeItem = value; }
        public int getvalue()
        { return nodeItem; }
        public void setvalue(int id)
        { nodeItem = id; }
    }

    class Heap
    {
        private Node[] heapArray;
        private int maxSize;
        private int currentSize;
        public Heap(int maxHeapSize)
        {
            maxSize = maxHeapSize;
            currentSize = 0;
            heapArray = new Node[maxSize];
        }
        public bool IsEmpty()
        { return currentSize == 0; }
        public bool Insert(int value)
        {
            if (currentSize == maxSize)
                return false;
            Node newNode = new Node(value);
            heapArray[currentSize] = newNode;
            CascadeUp(currentSize++);
            return true;
        }
        public void CascadeUp(int index)
        {
            int parent = (index - 1) / 2;
            Node bottom = heapArray[index];
            while (index > 0 && heapArray[parent].getvalue() > bottom.getvalue())
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }
        public Node Remove() // Remove maximum value node
        {
            Node root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            CascadeDown(0);
            return root;
        }
        public void CascadeDown(int index)
        {
            int largerChild;
            Node top = heapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                if (rightChild < currentSize && heapArray[leftChild].getvalue() > heapArray[rightChild].getvalue())
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (top.getvalue() <= heapArray[largerChild].getvalue())
                    break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;
        }
    }
}
