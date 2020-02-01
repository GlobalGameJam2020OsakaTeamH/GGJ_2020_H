using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntegerMediator : MediatorUI<int>
{
    UIComponent targetField;

    public override int TextToValue(string text)
    {
        if(UIComponents.Length == 0){
            return -1;
        }
        else{
            return int.Parse(text);
        }
    }

    #region BindingSource Implementation
 
    public override int getValueInteger(){
        return this.Value;
    }

    public override void setFromObject(object value)
    {  
        int temp = VariableUtilities.getValueInteger(value);
        this.Value = temp;
    }

    public override void setFromValueString(string valueString)
    {
        int temp;
        if(int.TryParse(valueString.Split()[0],out temp)){
            this.Value = temp;
        }
        else{
            throw new System.NotSupportedException("value string passed could not be converted to a int: " + temp);
        }
    }

    #endregion
}
