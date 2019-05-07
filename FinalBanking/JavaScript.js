function validate() {
    var custname = document.getElementById("custnameTextBox1").value;
    var ssnid = document.getElementById("custssnidTextBox1").value;

    if (!name(custname))
    {
        document.getElementById("namerr").innerHTML = "Enter correct format";
        document.getElementById("custnameTextBox1").focus;
        return false;
    }
    else if (id(!ssnid))
    {
        document.getElementById("numerr").innerHTML = "Enter correct id";
        document.getElementById("custssnidTextBox1").focus;
        return false;
    }
}

function name(custname)
{
    for (var i = 0; i < custname.Length; i++)
    {
        if (custname.charAt[i] >= 'a' && custname.charAt[i] <= 'z' || custname.charAt[i] <= 'A' && custname.charAt[i] >= 'Z')
        { }
        else
        {
            return false;
        }
        return true;
    }
}
function id(ssnid)
{
    for (var i = 0; i < ssnid.Length; i++)
    {
        if (ssnid.charAt[i] >= '0' && ssnid.charAt[i] <= '9')
        {
           
        }
        else {
            result = false;
        }
        return true;

    }
}