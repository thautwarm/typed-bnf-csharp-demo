grammar testjson;
options { language = CSharp; }
json returns [json result] :
      '[' local__2_json_case0=gen__seplist__L44__json ']' { 
        json tmp__2 ; 
        System.Collections.Generic.List<json> tmp__1 ; 
        tmp__1 = ( System.Collections.Generic.List<json> ) _localctx.local__2_json_case0.result ; 
        tmp__2 = (json) json_list( tmp__1 ); 
        $result = tmp__2; 
      } 
    | '{' local__2_json_case1=gen__seplist__L44__pair '}' { 
        json tmp__5 ; 
        System.Collections.Generic.Dictionary<string, json> tmp__4 ; 
        System.Collections.Generic.List<(string, json)> tmp__3 ; 
        tmp__3 = ( System.Collections.Generic.List<(string, json)> ) _localctx.local__2_json_case1.result ; 
        tmp__4 = (System.Collections.Generic.Dictionary<string, json>) mk_dict<string,json>( tmp__3 ); 
        tmp__5 = (json) json_dict( tmp__4 ); 
        $result = tmp__5; 
      } 
    | local__1_json_case2=INT_5 { 
        json tmp__8 ; 
        int tmp__7 ; 
        CommonToken tmp__6 ; 
        tmp__6 = ( CommonToken ) _localctx.local__1_json_case2 ; 
        tmp__7 = (int) parse_int( tmp__6.Text ); 
        tmp__8 = (json) json_int( tmp__7 ); 
        $result = tmp__8; 
      } 
    | local__1_json_case3=FLOAT_6 { 
        json tmp__11 ; 
        float tmp__10 ; 
        CommonToken tmp__9 ; 
        tmp__9 = ( CommonToken ) _localctx.local__1_json_case3 ; 
        tmp__10 = (float) parse_float( tmp__9.Text ); 
        tmp__11 = (json) json_float( tmp__10 ); 
        $result = tmp__11; 
      } 
    | local__1_json_case4=str { 
        json tmp__14 ; 
        string tmp__13 ; 
        string tmp__12 ; 
        tmp__12 = ( string ) _localctx.local__1_json_case4.result ; 
        tmp__13 = (string) unesc_string( tmp__12 ); 
        tmp__14 = (json) json_string( tmp__13 ); 
        $result = tmp__14; 
      } 
    | 'null' { 
        json tmp__15 ; 
        tmp__15 = (json) json_null(  ); 
        $result = tmp__15; 
      } 
; 
gen__seplist__L44__pair returns [System.Collections.Generic.List<(string, json)> result] :
      local__1_gen__seplist__L44__pair_case0=gen__seplist__L44__pair ',' local__3_gen__seplist__L44__pair_case0=pair { 
        System.Collections.Generic.List<(string, json)> tmp__18 ; 
        (string, json) tmp__17 ; 
        System.Collections.Generic.List<(string, json)> tmp__16 ; 
        tmp__16 = ( System.Collections.Generic.List<(string, json)> ) _localctx.local__1_gen__seplist__L44__pair_case0.result ; 
        tmp__17 = ( (string, json) ) _localctx.local__3_gen__seplist__L44__pair_case0.result ; 
        tmp__18 = (System.Collections.Generic.List<(string, json)>) append<(string, json)>( tmp__16, tmp__17 ); 
        $result = tmp__18; 
      } 
    | local__1_gen__seplist__L44__pair_case1=pair { 
        System.Collections.Generic.List<(string, json)> tmp__21 ; 
        (string, json) tmp__20 ; 
        System.Collections.Generic.List<(string, json)> tmp__19 ; 
        tmp__19 = (System.Collections.Generic.List<(string, json)>) nil<(string, json)>(  ); 
        tmp__20 = ( (string, json) ) _localctx.local__1_gen__seplist__L44__pair_case1.result ; 
        tmp__21 = (System.Collections.Generic.List<(string, json)>) append<(string, json)>( tmp__19, tmp__20 ); 
        $result = tmp__21; 
      } 
    | { 
        System.Collections.Generic.List<(string, json)> tmp__22 ; 
        tmp__22 = (System.Collections.Generic.List<(string, json)>) nil<(string, json)>(  ); 
        $result = tmp__22; 
      } 
; 
gen__seplist__L44__json returns [System.Collections.Generic.List<json> result] :
      local__1_gen__seplist__L44__json_case0=gen__seplist__L44__json ',' local__3_gen__seplist__L44__json_case0=json { 
        System.Collections.Generic.List<json> tmp__25 ; 
        json tmp__24 ; 
        System.Collections.Generic.List<json> tmp__23 ; 
        tmp__23 = ( System.Collections.Generic.List<json> ) _localctx.local__1_gen__seplist__L44__json_case0.result ; 
        tmp__24 = ( json ) _localctx.local__3_gen__seplist__L44__json_case0.result ; 
        tmp__25 = (System.Collections.Generic.List<json>) append<json>( tmp__23, tmp__24 ); 
        $result = tmp__25; 
      } 
    | local__1_gen__seplist__L44__json_case1=json { 
        System.Collections.Generic.List<json> tmp__28 ; 
        json tmp__27 ; 
        System.Collections.Generic.List<json> tmp__26 ; 
        tmp__26 = (System.Collections.Generic.List<json>) nil<json>(  ); 
        tmp__27 = ( json ) _localctx.local__1_gen__seplist__L44__json_case1.result ; 
        tmp__28 = (System.Collections.Generic.List<json>) append<json>( tmp__26, tmp__27 ); 
        $result = tmp__28; 
      } 
    | { 
        System.Collections.Generic.List<json> tmp__29 ; 
        tmp__29 = (System.Collections.Generic.List<json>) nil<json>(  ); 
        $result = tmp__29; 
      } 
; 
pair returns [(string, json) result] :
      local__1_pair_case0=str ':' local__3_pair_case0=json { 
        json tmp__32 ; 
        string tmp__31 ; 
        (string, json) tmp__30 ; 
        tmp__31 = ( string ) _localctx.local__1_pair_case0.result ; 
        tmp__32 = ( json ) _localctx.local__3_pair_case0.result ; 
        tmp__30 = ( tmp__31 , tmp__32 ); 
        $result = tmp__30; 
      } 
; 
str returns [string result] :
      local__1_str_case0=STR_2 { 
        CommonToken tmp__33 ; 
        tmp__33 = ( CommonToken ) _localctx.local__1_str_case0 ; 
        $result = tmp__33.Text; 
      } 
; 
start returns [json result] :
      local__1_start_case0=json EOF { 
        json tmp__34 ; 
        tmp__34 = ( json ) _localctx.local__1_start_case0.result ; 
        $result = tmp__34; 
      } 
; 


fragment ESCAPED_QUOTE_1 : '\\' '"';
STR_2 : '"' (ESCAPED_QUOTE_1|~'"')* '"';
WS_3 : ('\r'|'\t'|'\n'|' ') -> skip;
INT_5 : DIGIT_4+;
fragment DIGIT_4 : [\u0030-\u0039];
FLOAT_6 : INT_5 '.' INT_5;


