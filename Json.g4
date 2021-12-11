grammar Json;
options { language = CSharp; }
json returns [JsonValue result] :
      '[' local__2_json_case0=gen__nullable_gen__seplist__L44__json ']' { 
        JsonValue tmp__2 ; 
        System.Collections.Generic.List<JsonValue> tmp__1 ; 
        tmp__1 = ( System.Collections.Generic.List<JsonValue> ) _localctx.local__2_json_case0.result ; 
        tmp__2 = (JsonValue) json_list( tmp__1 ); 
        $result = tmp__2; 
      } 
    | '{' local__2_json_case1=gen__nullable_gen__seplist__L44__pair '}' { 
        JsonValue tmp__4 ; 
        System.Collections.Generic.List<(string, JsonValue)> tmp__3 ; 
        tmp__3 = ( System.Collections.Generic.List<(string, JsonValue)> ) _localctx.local__2_json_case1.result ; 
        tmp__4 = (JsonValue) json_dict( tmp__3 ); 
        $result = tmp__4; 
      } 
    | local__1_json_case2=INT_6 { 
        JsonValue tmp__7 ; 
        int tmp__6 ; 
        CommonToken tmp__5 ; 
        tmp__5 = ( CommonToken ) _localctx.local__1_json_case2 ; 
        tmp__6 = (int) parse_int( tmp__5.Text ); 
        tmp__7 = (JsonValue) json_int( tmp__6 ); 
        $result = tmp__7; 
      } 
    | local__1_json_case3=FLOAT_7 { 
        JsonValue tmp__10 ; 
        float tmp__9 ; 
        CommonToken tmp__8 ; 
        tmp__8 = ( CommonToken ) _localctx.local__1_json_case3 ; 
        tmp__9 = (float) parse_float( tmp__8.Text ); 
        tmp__10 = (JsonValue) json_float( tmp__9 ); 
        $result = tmp__10; 
      } 
    | local__1_json_case4=str { 
        JsonValue tmp__12 ; 
        string tmp__11 ; 
        tmp__11 = ( string ) _localctx.local__1_json_case4.result ; 
        tmp__12 = (JsonValue) json_string( tmp__11 ); 
        $result = tmp__12; 
      } 
    | 'null' { 
        JsonValue tmp__13 ; 
        tmp__13 = (JsonValue) json_null(  ); 
        $result = tmp__13; 
      } 
    | 'true' { 
        JsonValue tmp__15 ; 
        int tmp__14 ; 
        tmp__14 = 1 ; 
        tmp__15 = (JsonValue) json_bool( tmp__14 ); 
        $result = tmp__15; 
      } 
    | 'false' { 
        JsonValue tmp__17 ; 
        int tmp__16 ; 
        tmp__16 = 0 ; 
        tmp__17 = (JsonValue) json_bool( tmp__16 ); 
        $result = tmp__17; 
      } 
; 
gen__nullable_gen__seplist__L44__pair returns [System.Collections.Generic.List<(string, JsonValue)> result] :
      local__1_gen__nullable_gen__seplist__L44__pair_case0=gen__seplist__L44__pair { 
        System.Collections.Generic.List<(string, JsonValue)> tmp__18 ; 
        tmp__18 = ( System.Collections.Generic.List<(string, JsonValue)> ) _localctx.local__1_gen__nullable_gen__seplist__L44__pair_case0.result ; 
        $result = tmp__18; 
      } 
    | { 
        System.Collections.Generic.List<(string, JsonValue)> tmp__19 ; 
        tmp__19 = new System.Collections.Generic.List<(string, JsonValue)> { }; 
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
        (string, JsonValue) tmp__24 ; 
        System.Collections.Generic.List<(string, JsonValue)> tmp__23 ; 
        tmp__24 = ( (string, JsonValue) ) _localctx.local__1_gen__seplist__L44__pair_case1.result ; 
        tmp__23 = new System.Collections.Generic.List<(string, JsonValue)> { tmp__24 }; 
        $result = tmp__23; 
      } 
; 
gen__nullable_gen__seplist__L44__json returns [System.Collections.Generic.List<JsonValue> result] :
      local__1_gen__nullable_gen__seplist__L44__json_case0=gen__seplist__L44__json { 
        System.Collections.Generic.List<JsonValue> tmp__25 ; 
        tmp__25 = ( System.Collections.Generic.List<JsonValue> ) _localctx.local__1_gen__nullable_gen__seplist__L44__json_case0.result ; 
        $result = tmp__25; 
      } 
    | { 
        System.Collections.Generic.List<JsonValue> tmp__26 ; 
        tmp__26 = new System.Collections.Generic.List<JsonValue> { }; 
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
        JsonValue tmp__31 ; 
        System.Collections.Generic.List<JsonValue> tmp__30 ; 
        tmp__31 = ( JsonValue ) _localctx.local__1_gen__seplist__L44__json_case1.result ; 
        tmp__30 = new System.Collections.Generic.List<JsonValue> { tmp__31 }; 
        $result = tmp__30; 
      } 
; 
pair returns [(string, JsonValue) result] :
      local__1_pair_case0=str ':' local__3_pair_case0=json { 
        JsonValue tmp__34 ; 
        string tmp__33 ; 
        (string, JsonValue) tmp__32 ; 
        tmp__33 = ( string ) _localctx.local__1_pair_case0.result ; 
        tmp__34 = ( JsonValue ) _localctx.local__3_pair_case0.result ; 
        tmp__32 = ( tmp__33 , tmp__34 ); 
        $result = tmp__32; 
      } 
; 
str returns [string result] :
      local__1_str_case0=STR_2 { 
        string tmp__36 ; 
        CommonToken tmp__35 ; 
        tmp__35 = ( CommonToken ) _localctx.local__1_str_case0 ; 
        tmp__36 = (string) unesc_string( tmp__35.Text ); 
        $result = tmp__36; 
      } 
; 
start returns [JsonValue result] :
      local__1_start_case0=json EOF { 
        JsonValue tmp__37 ; 
        tmp__37 = ( JsonValue ) _localctx.local__1_start_case0.result ; 
        $result = tmp__37; 
      } 
; 


fragment ESCAPED_QUOTE_1 : '\\' '"';
STR_2 : '"' (ESCAPED_QUOTE_1|~'"')* '"';
WS_3 : ('\r'|'\t'|'\n'|' ') -> skip;
fragment EXP_5 : ('E'|'e') DIGIT_4+;
INT_6 : '-'? DIGIT_4+ EXP_5?;
fragment DIGIT_4 : [\u0030-\u0039];
FLOAT_7 : '-'? INT_6 '.' INT_6 EXP_5?;


