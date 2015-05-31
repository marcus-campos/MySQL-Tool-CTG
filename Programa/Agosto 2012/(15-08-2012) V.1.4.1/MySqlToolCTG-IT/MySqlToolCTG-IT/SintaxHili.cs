using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MySqlToolCTG_IT
{
    class SintaxHili
    {
        public Regex Syntaxes = new Regex("Select|select|Desc|desc|From|from|Show|show|Update|update|Delete|delete|"
                                         + "Use|use|Create|create|Table|table|Drop|drop|Trigger|trigger|Procedure|procedure|"
                                         + "Insert|insert|Into|into|Values|values|Varchar|varchar|Int|int|Integer|integer|Tynint|tynint|"
                                         + "Blob|blob|Text|text|Char|char|IF|if|If|Else|else|Double|double|Database|database|Set|set|Status|status|Where|where|>|<|=|'|'|(|)");
        
    }
}
