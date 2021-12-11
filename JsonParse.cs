using System;
using System.Collections.Generic;
using Antlr4.Runtime;
using System.Linq;

namespace JsonParse
{
    public interface JsonValue
    {
        public string show();

        public static JsonValue Parse(string s)
        {
            ICharStream stream = CharStreams.fromString(s);
            ITokenSource lexer = new JsonLexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            var parser = new JsonParser(tokens);
            parser.BuildParseTree = false;
            var result = parser.start().result;
            return result;
        }
    }

    public class JNull : JsonValue
    {
        public string show() => "null";
    }

    public class JList : JsonValue
    {
        public List<JsonValue> contents;
        public JList(List<JsonValue> cs) { contents = cs; }
        public string show() =>
            "[" + String.Join(", ", contents.Select(x => x.show())) + "]";
    }

    public class JDict : JsonValue
    {
        public Dictionary<string, JsonValue> contents;
        public JDict(Dictionary<string, JsonValue> cs) { contents = cs; }

        public string show() =>
            "{" + String.Join(", ", contents.Select(x => JsonParser.esc_string(x.Key) + ":" + x.Value.show())) + "}";
    }

    public class JInt : JsonValue
    {
        public int contents;
        public JInt(int cs) { contents = cs; }
        public string show() => contents.ToString();
    }

    public class JFloat : JsonValue
    {
        public float contents;
        public JFloat(float cs) { contents = cs; }

        public string show() => contents.ToString();

    }



    public class JString : JsonValue
    {
        public string contents;
        public JString(string cs) { contents = cs; }
        public string show() => JsonParser.esc_string(contents.ToString());
    }

    public class JBool : JsonValue
    {
        public bool contents;
        public JBool(bool cs) { contents = cs; }
        public string show() => contents.ToString();
    }

    public partial class JsonParser
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
        public static int parse_int(string s) => int.Parse(s, System.Globalization.NumberStyles.AllowExponent);
        public static float parse_float(string s) => float.Parse(s);

        public static JList json_list(List<JsonValue> cs) =>
            new JList(cs);
        public static JDict json_dict(List<(string, JsonValue)> cs) =>
            new JDict(mk_dict(cs));
        public static JInt json_int(int cs) =>
            new JInt(cs);

        public static JFloat json_float(float cs) =>
            new JFloat(cs);
        public static JString json_string(string cs) =>
            new JString(cs);

        public static JNull json_null() =>
            new JNull();
        public static JBool json_bool(int i) =>
            i == 0 ? new JBool(false) : new JBool(true);

        public static string unesc_string(string s) =>
            System.Text.RegularExpressions.Regex.Unescape(s.Substring(1, s.Length - 2));
        public static string esc_string(string s) =>
            "\"" + System.Text.RegularExpressions.Regex.Escape(s).Replace("\"", "\\\"") + "\"";
    }

#if APP
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            var result = JsonValue.Parse(input);
            Console.WriteLine(result.show() + " " + result.GetType());
        }
    }
#endif

}