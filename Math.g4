grammar Math;

fragment Digit : [0-9] ;

PositiveInt : Digit+;

PositiveFloat : Digit* '.' Digit+ ;

WS: [ \t\r\n]+ -> skip;

exp
    : PositiveInt   #IntNumber
    | PositiveFloat #FloatNumber
    | '(' exp ')'   #ParensExpression
    | exp '^' exp   #ExponentialExpression
    | '-' exp       #NegationExpression
    | exp '*' exp   #MultiplicationExpression
    | exp '/' exp   #DivisionExpression
    | exp '+' exp   #AdditionExpression
    | exp '-' exp   #SubtractionExpression
    | 'sin' '(' exp ')'   #SineExpression
    | 'cos' '(' exp ')'   #CosineExpression
    | 'tan' '(' exp ')'   #TangentExpression
    | 'pi'   #PiExpression
    | 'Pi'   #PiExpression
    ;