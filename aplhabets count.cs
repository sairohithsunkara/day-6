using Systems;
using Systems.Collections;
using Systems.Collections.Generic;
class gencol {
    public static void Main() {
    string Input = "aabbbbcd";
        Dictionary < char, int >keyValuePairs = new Dictionary < char, int >();
        foreach (var item in Input)
        {
          int counter;
          keyValuePairs.TryGetValue (item, out counter);
          if (counter == 0)
            {
              keyValuePairs.Add (item, 1);
            }
          else
            {
              keyValuePairs.Remove (item);
              keyValuePairs.Add (item, counter + 1);
            }
        }
        
        foreach (var item in keyValuePairs)
        {
          Console.WriteLine (item.Key + " - " + item.Value);
        }
}
}