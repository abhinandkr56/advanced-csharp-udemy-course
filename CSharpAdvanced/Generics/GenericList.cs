namespace CSharpAdvanced;

public class GenericList<T>
{
   public List<T> items = new List<T>();
   public void Add(T item)
   {
      items.Add(item);
   }

   public T this[int index]
   {
      get
      {
         return items[index];
      }
   }
}