grammar JsonParse;
options { language = CSharp; }
json returns [JsonValue result] :
      '[' local__2_json_case0=gen__seplist__L44__json ']' { 
        JsonValue tmp__2 ; 
        System.Collections.Generic.List<JsonValue> tmp__1 ; 
        tmp__1 = ( System.Collections.Generic.List<JsonValue> ) _localctx.local__2_json_case0.result ; 
        tmp__2 = (JsonValue) json_list( tmp__1 ); 
        $result = tmp__2; 
      } 
    | '{' local__2_json_case1=gen__seplist__L44__pair '}' { 
        JsonValue tmp__5 ; 
        System.Collections.Generic.Dictionary<string, JsonValue> tmp__4 ; 
        System.Collections.Generic.List<(string, JsonValue)> tmp__3 ; 
        tmp__3 = ( System.Collections.Generic.List<(string, JsonValue)> ) _localctx.local__2_json_case1.result ; 
        tmp__4 = (System.Collections.Generic.Dictionary<string, JsonValue>) mk_dict<string,JsonValue>( tmp__3 ); 
        tmp__5 = (JsonValue) json_dict( tmp__4 ); 
        $result = tmp__5; 
      } 
    | local__1_json_case2=INT_6 { 
        JsonValue tmp__8 ; 
        int tmp__7 ; 
        CommonToken tmp__6 ; 
        tmp__6 = ( CommonToken ) _localctx.local__1_json_case2 ; 
        tmp__7 = (int) parse_int( tmp__6.Text ); 
        tmp__8 = (JsonValue) json_int( tmp__7 ); 
        $result = tmp__8; 
      } 
    | local__1_json_case3=FLOAT_7 { 
        JsonValue tmp__11 ; 
        float tmp__10 ; 
        CommonToken tmp__9 ; 
        tmp__9 = ( CommonToken ) _localctx.local__1_json_case3 ; 
        tmp__10 = (float) parse_float( tmp__9.Text ); 
        tmp__11 = (JsonValue) json_float( tmp__10 ); 
        $result = tmp__11; 
      } 
    | local__1_json_case4=str { 
        JsonValue tmp__14 ; 
        string tmp__13 ; 
        string tmp__12 ; 
        tmp__12 = ( string ) _localctx.local__1_json_case4.result ; 
        tmp__13 = (string) unesc_string( tmp__12 ); 
        tmp__14 = (JsonValue) json_string( tmp__13 ); 
        $result = tmp__14; 
      } 
    | 'null' { 
        JsonValue tmp__15 ; 
        tmp__15 = (JsonValue) json_null(  ); 
        $result = tmp__15; 
      } 
    | 'true' { 
        JsonValue tmp__17 ; 
        int tmp__16 ; 
        tmp__16 = 1 ; 
        tmp__17 = (JsonValue) json_bool( tmp__16 ); 
        $result = tmp__17; 
      } 
    | 'false' { 
        JsonValue tmp__19 ; 
        int tmp__18 ; 
        tmp__18 = 0 ; 
        tmp__19 = (JsonValue) json_bool( tmp__18 ); 
        $result = tmp__19; 
      } 
; 
gen__seplist__L44__pair returns [System.Collections.Generic.List<(string, JsonValue)> result] :
      local__1_gen__seplist__L44__pair_case0=gen__seplist__L44__pair ',' local__3_gen__seplist__L44__pair_case0=pair { 
        System.Collections.Generic.List<(string, JsonValue)> tmp__22 ; 
        (string, JsonValue) tmp__21 ; 
        System.Collections.Generic.List<(string, JsonValue)> tmp__20 ; 
        tmp__20 = ( System.Collections.Generic.List<(string, JsonValue)> ) _localctx.local__1_gen__seplist__L44__pair_case0.result ; 
        tmp__21 = ( (string, JsonValue) ) _localctx.local__3_gen__seplist__L44__pair_case0.result ; 
        tmp__22 = (System.Collections.Generic.List<(string, JsonValue)>) append<(string, JsonValue)>( tmp__20, tmp__21 ); 
        $result = tmp__22; 
      } 
    | local__1_gen__seplist__L44__pair_case1=pair { 
        System.Collections.Generic.List<(string, JsonValue)> tmp__25 ; 
        (string, JsonValue) tmp__24 ; 
        System.Collections.Generic.List<(string, JsonValue)> tmp__23 ; 
        tmp__23 = (System.Collections.Generic.List<(string, JsonValue)>) nil<(string, JsonValue)>(  ); 
        tmp__24 = ( (string, JsonValue) ) _localctx.local__1_gen__seplist__L44__pair_case1.result ; 
        tmp__25 = (System.Collections.Generic.List<(string, JsonValue)>) append<(string, JsonValue)>( tmp__23, tmp__24 ); 
        $result = tmp__25; 
      } 
    | { 
        System.Collections.Generic.List<(string, JsonValue)> tmp__26 ; 
        tmp__26 = (System.Collections.Generic.List<(string, JsonValue)>) nil<(string, JsonValue)>(  ); 
        $result = tmp__26; 
      } 
; 
gen__seplist__L44__json returns [System.Collections.Generic.List<JsonValue> result] :
      local__1_gen__seplist__L44__json_case0=gen__seplist__L44__json ',' local__3_gen__seplist__L44__json_case0=json { 
        System.Collections.Generic.List<JsonValue> tmp__29 ; 
        JsonValue tmp__28 ; 
        System.Collections.Generic.List<JsonValue> tmp__27 ; 
        tmp__27 = ( System.Collections.Generic.List<JsonValue> ) _localctx.local__1_gen__seplist__L44__json_case0.result ; 
        tmp__28 = ( JsonValue ) _localctx.local__3_gen__seplist__L44__json_case0.result ; 
        tmp__29 = (System.Collections.Generic.List<JsonValue>) append<JsonValue>( tmp__27, tmp__28 ); 
        $result = tmp__29; 
      } 
    | local__1_gen__seplist__L44__json_case1=json { 
        System.Collections.Generic.List<JsonValue> tmp__32 ; 
        JsonValue tmp__31 ; 
        System.Collections.Generic.List<JsonValue> tmp__30 ; 
        tmp__30 = (System.Collections.Generic.List<JsonValue>) nil<JsonValue>(  ); 
        tmp__31 = ( JsonValue ) _localctx.local__1_gen__seplist__L44__json_case1.result ; 
        tmp__32 = (System.Collections.Generic.List<JsonValue>) append<JsonValue>( tmp__30, tmp__31 ); 
        $result = tmp__32; 
      } 
    | { 
        System.Collections.Generic.List<JsonValue> tmp__33 ; 
        tmp__33 = (System.Collections.Generic.List<JsonValue>) nil<JsonValue>(  ); 
        $result = tmp__33; 
      } 
; 
pair returns [(string, JsonValue) result] :
      local__1_pair_case0=str ':' local__3_pair_case0=json { 
        JsonValue tmp__36 ; 
        string tmp__35 ; 
        (string, JsonValue) tmp__34 ; 
        tmp__35 = ( string ) _localctx.local__1_pair_case0.result ; 
        tmp__36 = ( JsonValue ) _localctx.local__3_pair_case0.result ; 
        tmp__34 = ( tmp__35 , tmp__36 ); 
        $result = tmp__34; 
      } 
; 
str returns [string result] :
      local__1_str_case0=STR_2 { 
        CommonToken tmp__37 ; 
        tmp__37 = ( CommonToken ) _localctx.local__1_str_case0 ; 
        $result = tmp__37.Text; 
      } 
; 
start returns [JsonValue result] :
      local__1_start_case0=json EOF { 
        JsonValue tmp__38 ; 
        tmp__38 = ( JsonValue ) _localctx.local__1_start_case0.result ; 
        $result = tmp__38; 
      } 
; 


fragment ESCAPED_QUOTE_1 : '\\' '"';
STR_2 : '"' (ESCAPED_QUOTE_1|~'"')* '"';
WS_3 : ('\r'|'\t'|'\n'|' ') -> skip;
fragment EXP_5 : 'E' DIGIT_4+;
INT_6 : DIGIT_4+ EXP_5;
fragment DIGIT_4 : [\u0030-\u0039];
FLOAT_7 : INT_6 '.' INT_6 EXP_5;


