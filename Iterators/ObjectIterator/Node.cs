namespace ObjectIterator;  

public class Node<T>
{
  public T Value;
  public Node<T> Left, Right;
  public Node<T> Parent;

  public Node(T value)
  {
    this.Value = value;
  }

  public Node(T value, Node<T> left, Node<T> right)
  {
    this.Value = value;
    this.Left = left;
    this.Right = right;

    left.Parent = right.Parent = this;
  }
}
