grammar Calc;
options{language = CSharp3;}

@header{
	using System;
	using System.Collections;
}

@members{
	Hashtable memory = new Hashtable();
}
    
public calc: statement+;  // Infinite number of expressions
	
statement: 
      expr NEWLINE { Console.WriteLine($expr.value); } // Possible expressions
	| ID '=' expr NEWLINE { memory.Add($ID.text, $expr.value); } // Assigning a value to a variable
	| NEWLINE // List of valid end-of-expression characters
;
	
expr returns[int value]: 
         me1=multExpression {$value = me1;} (
    '+'  me2=multExpression {$value += $me2.value;}
    |'-' me2=multExpression {$value -= $me2.value;})*
;

multExpression returns[int value]: 
                  a1=atom {$value = $a1.value;} (
    '*'           a2=atom {$value *= $a2.value;}
    | ('/' | ':') a2=atom {$value /= $a2.value;})*
;
	
atom returns[int value]:  // Options for possible characters. Mapping to data type. lexemes. words of formal language
	  ID {$value = (int)memory[$ID.text];}
	| INT {$value = int.Parse($INT.text);}
	| '(' expr ')' {$value = $expr.value;}  
;

ID: ('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')* ; // Assigning a value to a variable
INT: '0'..'9'+ ; // Specifies the data type: numbers only
NEWLINE: '\r'? '\n'? | ';' ;  // List of valid end-of-expression characters  
