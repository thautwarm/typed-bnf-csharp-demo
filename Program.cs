using System;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.Linq;
public interface json
{
    public string show();
}

public class jsonNull : json
{
    public string show() => "null";
}

public class jsonList : json
{
    public List<json> contents;
    public jsonList(List<json> cs) { contents = cs; }
    public string show() =>
        "[" + String.Join(", ", contents.Select(x => x.show())) + "]";
}

public class jsonDict : json
{
    public Dictionary<string, json> contents;
    public jsonDict(Dictionary<string, json> cs) { contents = cs; }

    public string show() =>
        "{" + String.Join(", ", contents.Select(x => x.Key + ":" + x.Value.show())) + "}";
}

public class jsonInt : json
{
    public int contents;
    public jsonInt(int cs) { contents = cs; }
    public string show() => contents.ToString();
}

public class jsonFloat : json
{
    public float contents;
    public jsonFloat(float cs) { contents = cs; }

    public string show() => contents.ToString();

}



public class jsonString : json
{
    public string contents;
    public jsonString(string cs) { contents = cs; }
    public string show() => contents.ToString();
}

public partial class testjsonParser
{
    public static List<T> nil<T>() => new List<T>();

    public static List<T> append<T>(List<T> lst, T e)
    {
        lst.Add(e);
        return lst;
    }
    public static Dictionary<K, V> mk_dict<K, V>(List<(K, V)> lst)
    {
        var ret = new Dictionary<K, V>();
        foreach (var (k, v) in lst)
        {
            ret[k] = v;
        }
        return ret;
    }
    public static int parse_int(string s) => int.Parse(s);
    public static float parse_float(string s) => float.Parse(s);

    public static jsonList json_list(List<json> cs) =>
        new jsonList(cs);
    public static jsonDict json_dict(Dictionary<string, json> cs) =>
        new jsonDict(cs);
    public static jsonInt json_int(int cs) =>
        new jsonInt(cs);

    public static jsonFloat json_float(float cs) =>
        new jsonFloat(cs);
    public static jsonString json_string(string cs) =>
        new jsonString(cs);

    public static jsonNull json_null() =>
        new jsonNull();

    public static string unesc_string(string s) =>
        s.Substring(1, s.Length - 1).Replace("\\\"", "\"");

}
class Program
{
    static void Main(string[] args)
    {

        String input = "[1, 2, [{}, {\"a\": [null, null]}]]";
        ICharStream stream = CharStreams.fromString(input);
        ITokenSource lexer = new testjsonLexer(stream);
        ITokenStream tokens = new CommonTokenStream(lexer);
        var parser = new testjsonParser(tokens);
        // parser.BuildParseTree = true;
        var result = parser.start().result;
        Console.WriteLine(result.show());

    }
}

