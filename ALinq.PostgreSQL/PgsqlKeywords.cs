﻿using ALinq.SqlClient;

namespace ALinq.PostgreSQL
{
    class PgsqlKeywords : Keywords<PgsqlKeywords>
    {
        public PgsqlKeywords()
        {
            AddRange(new[] { "A","ABORT","ABS","ABSOLUTE","ACCESS","ACTION","ADA","ADD","ADMIN","AFTER",
                             "AGGREGATE","ALIAS","ALL","ALLOCATE","ALSO","ALTER","ALWAYS","ANALYSE","ANALYZE","AND",
                             "ANY","ARE","ARRAY","AS","ASC","ASENSITIVE","ASSERTION","ASSIGNMENT","ASYMMETRIC","AT",
                             "ATOMIC","ATTRIBUTE","ATTRIBUTES","AUTHORIZATION","AVG" });
            AddRange(new[] { "BACKWARD","BEFORE","BEGIN","BERNOULLI","BETWEEN","BIGINT","BINARY","BIT","BITVAR",
                             "BIT_LENGTH","BLOB","BOOLEAN","BOTH","BREADTH","BY" });
            AddRange(new[] { "C","CACHE","CALL","CALLED","CARDINALITY","CASCADE","CASCADED","CASE","CAST","CATALOG",
                             "CATALOG_NAME","CEIL","CEILING","CHAIN","CHAR","CHARACTER","CHARACTERISTICS","CHARACTERS",
                             "CHARACTER_LENGTH","CHARACTER_SET_CATALOG","CHARACTER_SET_NAME","CHARACTER_SET_SCHEMA",
                             "CHAR_LENGTH","CHECK","CHECKED","CHECKPOINT","CLASS","CLASS_ORIGIN","CLOB","CLOSE","CLUSTER",
                             "COALESCE","COBOL","COLLATE","COLLATION","COLLATION_CATALOG","COLLATION_NAME","COLLATION_SCHEMA",
                             "COLLECT","COLUMN","COLUMN_NAME","COMMAND_FUNCTION","COMMAND_FUNCTION_CODE","COMMENT","COMMIT",
                             "COMMITTED","COMPLETION","CONDITION","CONDITION_NUMBER","CONNECT","CONNECTION","CONNECTION_NAME",
                             "CONSTRAINT","CONSTRAINTS","CONSTRAINT_CATALOG","CONSTRAINT_NAME","CONSTRAINT_SCHEMA","CONSTRUCTOR",
                             "CONTAINS","CONTINUE","CONVERSION","CONVERT","COPY","CORR","CORRESPONDING","COUNT","COVAR_POP",
                             "COVAR_SAMP","CREATE","CREATEDB","CREATEROLE","CREATEUSER","CROSS","CSV","CUBE","CUME_DISTCURRENT",
                             "CURRENT_DATE","CURRENT_DEFAULT_TRANSFORM_GROUP","CURRENT_PATH","CURRENT_ROLE","CURRENT_TIME",
                             "CURRENT_TIMESTAMP","CURRENT_TRANSFORM_GROUP_FOR_TYPE","CURRENT_USER","CURSOR","CURSOR_NAME","CYCLE"});
            AddRange(new[] { "DATA","DATABASE","DATE","DATETIME_INTERVAL_CODE","DATETIME_INTERVAL_PRECISION","DAY","DEALLOCATE",
                             "DEC","DECIMAL","DECLARE","DEFAULT","DEFAULTS","DEFERRABLE","DEFERRED","DEFINED","DEFINER","DEGREE",
                             "DELETE","DELIMITER","DELIMITERS","DENSE_RANK","DEPTH","DEREF","DERIVED","DESC","DESCRIBE","DESCRIPTOR",
                             "DESTROY","DESTRUCTOR","DETERMINISTIC","DIAGNOSTICS","DICTIONARY","DISABLE","DISCONNECT","DISPATCH",
                             "DISTINCT","DO","DOMAIN","DOUBLE","DROP","DYNAMIC","DYNAMIC_FUNCTION","DYNAMIC_FUNCTION_CODE" });
            AddRange(new[] { "EACH","ELEMENT","ELSE","ENABLE","ENCODING","ENCRYPTED","END","END-EXEC","EQUALS","ESCAPE","EVERY",
                             "EXCEPT","EXCEPTION","EXCLUDE","EXCLUDING","EXCLUSIVE","EXEC","EXECUTE","EXISTING","EXISTS","EXP",
                             "EXPLAIN","EXTERNAL","EXTRACT" });
            AddRange(new[] { "FALSE","FETCH","FILTER","FINAL","FIRST","FLOAT","FLOOR","FOLLOWING","FOR","FORCE","FOREIGN","FORTRAN",
                             "FORWARD","FOUND","FREE","FREEZE","FROM","FULL","FUNCTION","FUSION" });
            AddRange(new[] { "G", "GENERAL", "GENERATED", "GET", "GLOBAL", "GO", "GOTO", "GRANT", "GRANTED", "GREATEST", "GROUP", "GROUPING" });
            AddRange(new[] { "HANDLER", "HAVING", "HEADER", "HIERARCHY", "HOLD", "HOST", "HOUR" });
            AddRange(new[] { "IDENTITY","IGNORE","ILIKE","IMMEDIATE","IMMUTABLE","IMPLEMENTATION","IMPLICIT","IN","INCLUDING","INCREMENT",
                             "INDEX","INDICATOR","INFIX","INHERIT","INHERITS","INITIALIZE","INITIALLY","INNER","INOUT","INPUT","INSENSITIVE",
                             "INSERT","INSTANCE","INSTANTIABLE","INSTEAD","INT","INTEGER","INTERSECT","INTERSECTION","INTERVAL","INTO",
                             "INVOKER","IS","ISNULL","ISOLATION","ITERATE" });
            AddRange(new[] { "JOIN" });
            AddRange(new[] { "K", "KEY", "KEY_MEMBER", "KEY_TYPE" });
            AddRange(new[] { "LANCOMPILER","LANGUAGE","LARGE","LAST","LATERAL","LEADING","LEAST","LEFT","LENGTH","LESS","LEVEL","LIKE",
                             "LIMIT","LISTEN","LN","LOAD","LOCAL","LOCALTIME","LOCALTIMESTAMP","LOCATION","LOCATOR","LOCK","LOGIN","LOWER" });
            AddRange(new[] { "M","MAP","MATCH","MATCHED","MAX","MAXVALUE","MEMBER","MERGE","MESSAGE_LENGTH","MESSAGE_OCTET_LENGTH",
                             "MESSAGE_TEXT","METHOD","MIN","MINUTE","MINVALUE","MOD","MODE","MODIFIES","MODIFY","MODULE","MONTH","MORE",
                             "MOVE","MULTISET","MUMPS" });
            AddRange(new[] { "NAME","NAMES","NATIONAL","NATURAL","NCHAR","NCLOB","NESTING","NEW","NEXT","NO","NOCREATEDB","NOCREATEROLE",
                             "NOCREATEUSER","NOINHERIT","NOLOGIN","NONE","NORMALIZE","NORMALIZED","NOSUPERUSER","NOT","NOTHING",
                             "NOTIFY","NOTNULL","NOWAIT","NULL","NULLABLE","NULLIF","NULLS","NUMBER","NUMERIC" });
            AddRange(new[] { "OBJECT","OCTETS","OCTET_LENGTH","OF","OFF","OFFSET","OIDS","OLD","ON","ONLY","OPEN","OPERATION","OPERATOR",
                             "OPTION","OPTIONS","OR","ORDER","ORDERING","ORDINALITY","OTHERS","OUT","OUTER","OUTPUT","OVER","OVERLAPS",
                             "OVERLAY","OVERRIDING","OWNER" });
            AddRange(new[] { "PAD","PARAMETER","PARAMETERS","PARAMETER_MODE","PARAMETER_NAME","PARAMETER_ORDINAL_POSITION",
                             "PARAMETER_SPECIFIC_CATALOG","PARAMETER_SPECIFIC_NAME","PARAMETER_SPECIFIC_SCHEMA","PARTIAL",
                             "PARTITION","PASCAL","PASSWORD","PATH","PERCENTILE_CONT","PERCENTILE_DISC","PERCENT_RANK",
                             "PLACING","PLI","POSITION","POSTFIX","POWER","PRECEDING","PRECISION","PREFIX","PREORDER",
                             "PREPARE","PREPARED","PRESERVE","PRIMARY","PRIOR","PRIVILEGES","PROCEDURAL","PROCEDURE","PUBLIC" });
            AddRange(new[] { "QUOTE" });
            AddRange(new[] { "RANGE","RANK","READ","READS","REAL","RECHECK","RECURSIVE","REFREFERENCES","REFERENCING","REGR_AVGX",
                             "REGR_AVGY","REGR_COUNT","REGR_INTERCEPT","REGR_R2","REGR_SLOPE","REGR_SXX","REGR_SXY","REGR_SYY",
                             "REINDEX","RELATIVE","RELEASE","RENAME","REPEATABLE","REPLACE","RESET","RESTART","RESTRICT","RESULT",
                             "RETURN","RETURNED_CARDINALITY","RETURNED_LENGTH","RETURNED_OCTET_LENGTH","RETURNED_SQLSTATE",
                             "RETURNS","REVOKE","RIGHT","ROLE","ROLLBACK","ROLLUP","ROUTINE","ROUTINE_CATALOG","ROUTINE_NAME",
                             "ROUTINE_SCHEMA","ROW","ROWS","ROW_COUNT","ROW_NUMBER","RULE" });
            AddRange(new[] { "SAVEPOINT","SCALE","SCHEMA","SCHEMA_NAME","SCOPE","SCOPE_CATALOG","SCOPE_NAME","SCOPE_SCHEMA",
                             "SCROLL","SEARCH","SECOND","SECTION","SECURITY","SELECT","SELF","SENSITIVE","SEQUENCE","SERIALIZABLE",
                             "SERVER_NAME","SESSION","SESSION_USER","SET","SETOF","SETS","SHARE","SHOW","SIMILAR","SIMPLE",
                             "SIZE","SMALLINT","SOME","SOURCE","SPACE","SPECIFIC","SPECIFICTYPE","SPECIFIC_NAME","SQL","SQLCODE",
                             "SQLERROR","SQLEXCEPTION","SQLSTATE","SQLWARNING","SQRT","STABLE","START","STATE","STATEMENT","STATIC",
                             "STATISTICS","STDDEV_POP","STDDEV_SAMP","STDIN","STDOUT","STORAGE","STRICT","STRUCTURE","STYLE",
                             "SUBCLASS_ORIGIN","SUBLIST","SUBMULTISET","SUBSTRING","SUM","SUPERUSER","SYMMETRIC","SYSID","SYSTEM",
                             "SYSTEM_USER" });
            AddRange(new[] { "TABLE","TABLESAMPLE","TABLESPACE","TABLE_NAME","TEMP","TEMPLATE","TEMPORARY","TERMINATE","THAN","THEN",
                             "TIES","TIME","TIMESTAMP","TIMEZONE_HOUR","TIMEZONE_MINUTE","TO","TOAST","TOP_LEVEL_COUNT","TRAILING",
                             "TRANSACTION","TRANSACTIONS_COMMITTED","TRANSACTIONS_ROLLED_BACK","TRANSACTION_ACTIVE","TRANSFORM",
                             "TRANSFORMS","TRANSLATE","TRANSLATION","TREAT","TRIGGER","TRIGGER_CATALOG","TRIGGER_NAME","TRIGGER_SCHEMA",
                             "TRIM","TRUE","TRUNCATE","TRUSTED","TYPE" });
            AddRange(new[] { "UESCAPE","UNBOUNDED","UNCOMMITTED","UNDER","UNENCRYPTED","UNION","UNIQUE","UNKNOWN","UNLISTEN","UNNAMED",
                             "UNNEST","UNTIL","UPDATE","UPPER","USAGE","USER","USER_DEFINED_TYPE_CATALOG","USER_DEFINED_TYPE_CODE",
                             "USER_DEFINED_TYPE_NAME","USER_DEFINED_TYPE_SCHEMA","USING" });
            AddRange(new[] { "VACUUM","VALID","VALIDATOR","VALUE","VALUES","VARCHAR","VARIABLE","VARYING","VAR_POP","VAR_SAMP","VERBOSE",
                             "VIEW","VOLATILE" });
            AddRange(new[] { "WHEN", "WHENEVER", "WHERE", "WIDTH_BUCKET", "WINDOW", "WITH", "WITHIN", "WITHOUT", "WORK", "WRITE" });
            AddRange(new[] { "YEAR" });
            AddRange(new[] { "ZONE" });
        }
    }
}
