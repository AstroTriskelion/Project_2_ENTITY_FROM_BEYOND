using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _ENTITY : MonoBehaviour
{
    public string KeyInputs;
    public Text console;
    void Start()
    {
        Debug.Log("Digital piano online.");
        Debug.Log("Version 8.3.100. Press any key");
    }

    public void AddToString(string note)
	{
        KeyInputs = KeyInputs + note;
        Debug.Log("The current string has " + KeyInputs);
        Conditions();
    }

    public void Conditions()
    {
        if (KeyInputs.Length >= 9)
        {
            KeyInputs = "";
            Debug.Log("SEQUENCE FAILED");
        }

        // DO or C//
        // MAJOR // MINOR // AUGMENTED // DIMINISHED //
        if (KeyInputs.Contains("DOMISOL") || KeyInputs.Contains("MISOLDO/8") || KeyInputs.Contains("SOLDO/8MI"))
		{
            KeyInputs = ("");
            Debug.Log("DO MAJOR PLAYED");
        }
        else if (KeyInputs.Contains("DORE#SOL") || KeyInputs.Contains("RE#SOLDO/8") || KeyInputs.Contains("#SOLDO/8RE"))
        {
            KeyInputs = ("");
            Debug.Log("DO MINOR PLAYED");
        }
        else if (KeyInputs.Contains("DOMISOL#") || KeyInputs.Contains("MISOL#DO/8") || KeyInputs.Contains("SOL#DO/8MI"))
        {
            KeyInputs = ("");
            Debug.Log("DO AUGMENTED PLAYED");
        }        
        else if (KeyInputs.Contains("DORE#FA#") || KeyInputs.Contains("RE#FA#DO/8") || KeyInputs.Contains("FA#DO/8RE#"))
        {
            KeyInputs = ("DO DIMINISHED PLAYED");
        }
        
        // DO# or C#//
        // MAJOR// MINOR// AUGMENTED// DIMINISHED
        if (KeyInputs.Contains("DO#FASOL#") || KeyInputs.Contains("FASOL#DO#") || KeyInputs.Contains("SOL#DO#FA"))
        {
            KeyInputs = ("");
            Debug.Log("DO# MAJOR PLAYED");        }        
        if (KeyInputs.Contains("DO#MISOL#") || KeyInputs.Contains("MISOL#DO#") || KeyInputs.Contains("SOL#DO#MI"))
        {
            KeyInputs = ("");
            Debug.Log("DO# MINOR PLAYED");
        }       
        if (KeyInputs.Contains("DO#FALA") || KeyInputs.Contains("LADO#FA") || KeyInputs.Contains("FALADO#"))
        {
            KeyInputs = ("");
            Debug.Log("DO# AUGMENTED PLAYED");
        }      
        if (KeyInputs.Contains("DO#MISOL") || KeyInputs.Contains("MISOLDO#") || KeyInputs.Contains("SOLDO#MI"))
        {
            KeyInputs = ("");
            Debug.Log("DO# DIMISHED PLAYED");
        }
        
        // RE or D//
        // MAJOR// MINOR// AUGMENTED// DIMINISHED
        if (KeyInputs.Contains("REFA#LA") || KeyInputs.Contains("FA#LARE") || KeyInputs.Contains("LAREFA#"))
        {
            KeyInputs = ("");
            Debug.Log("RE MAJOR PLAYED");
        }   
        else if (KeyInputs.Contains("REFALA") || KeyInputs.Contains("FALARE") || KeyInputs.Contains("LAREFA"))
        {
            KeyInputs = ("");
            Debug.Log("RE MINOR PLAYED");
        }        
        else if (KeyInputs.Contains("REFA#LA#") || KeyInputs.Contains("FA#LA#RE") || KeyInputs.Contains("LA#REFA#"))
        {
            KeyInputs = ("");
            Debug.Log("RE AUGMENTED PLAYED");
        }       
        else if (KeyInputs.Contains("REFASOL#") || KeyInputs.Contains("FASOL#RE") || KeyInputs.Contains("SOL#REFA"))
        {
            KeyInputs = ("");
            Debug.Log("RE DIMISHED PLAYED");
        }
        
        // RE# //
        // MAJOR// MINOR// AUGMENTED// DIMINISHED
        if (KeyInputs.Contains("RE#SOLLA#") || KeyInputs.Contains("SOLLA#RE#") || KeyInputs.Contains("LA#RE#SOL"))
        {
            KeyInputs = ("");
            Debug.Log("RE# MAJOR PLAYED");
        }        
        else if (KeyInputs.Contains("RE#FA#SI#") || KeyInputs.Contains("FA#SI#RE#") || KeyInputs.Contains("SI#RE#FA#"))
        {
            KeyInputs = ("");
            Debug.Log("RE# MINOR PLAYED");
        }        
        else if (KeyInputs.Contains("RE#SOLSI") || KeyInputs.Contains("SOLSIRE#") || KeyInputs.Contains("SIRE#SOL"))
        {
            KeyInputs = ("");
            Debug.Log("RE# AUGMENTED PLAYED");
        }        
        else if (KeyInputs.Contains("RE#FA#LA") || KeyInputs.Contains("FA#LARE#") || KeyInputs.Contains("LARE#FA#"))
        {
            KeyInputs = ("");
            Debug.Log("RE# DIMINISHED PLAYED");
        }     

        // MI //
        // MAJOR// MINOR// AUGMENTED// DIMINISHED
        if (KeyInputs.Contains("MISOL#SI") || KeyInputs.Contains("SOL#SIMI") || KeyInputs.Contains("SIMISOL#"))
        {
            KeyInputs = ("");
            Debug.Log("MI MAJOR PLAYED");
        }       
        else if (KeyInputs.Contains("MISOLSI") || KeyInputs.Contains("SOLSIMI") || KeyInputs.Contains("SIMISOL"))
        {
            KeyInputs = ("");
            Debug.Log("MI MINOR PLAYED");
        }              
        else if (KeyInputs.Contains("MISOL#DO/8") || KeyInputs.Contains("SOL#DO/8MI") || KeyInputs.Contains("DO/8MISOL#") || KeyInputs.Contains("DOMISOL#") || KeyInputs.Contains("MISOL#DO"))
        {
            KeyInputs = ("");
            Debug.Log("MI AUGMENTED PLAYED");
        }               
        else if (KeyInputs.Contains("MISOLLA#") || KeyInputs.Contains("SOLLA#MI") || KeyInputs.Contains("LA#MISOL"))
        {
            KeyInputs = ("");
            Debug.Log("MI DIMINISHED PLAYED");
        }

        // FA //
        // MAJOR// MINOR// AUGMENTED// DIMINISHED
        if (KeyInputs.Contains("FALADO/8") || KeyInputs.Contains("LADO/8FA") || KeyInputs.Contains("DO/8FALA") || KeyInputs.Contains("DOFALA"))
        {
            KeyInputs = ("");
            Debug.Log("FA MAJOR PLAYED");
        }
        else if (KeyInputs.Contains("FASOL#DO/8") || KeyInputs.Contains("SOL#DO/8FA") || KeyInputs.Contains("DO/8FASOL#") || KeyInputs.Contains("DOFASOL#"))
        {
            KeyInputs = ("");
            Debug.Log("FA MINOR PLAYED");
        }
        else if (KeyInputs.Contains("FALADO#") || KeyInputs.Contains("LADO#FA") || KeyInputs.Contains("DO#FALA"))
        {
            KeyInputs = ("");
            Debug.Log("FA AUGMENTED PLAYED");
        }
        else if (KeyInputs.Contains("FASOL#SI") || KeyInputs.Contains("SOL#SIFA") || KeyInputs.Contains("SIFASOL#"))
        {
            KeyInputs = ("");
            Debug.Log("FA DIMINISHED PLAYED");
        }

        // FA# //
        // MAJOR// MINOR// AUGMENTED// DIMINISHED
        if (KeyInputs.Contains("FA#LA#DO#") || KeyInputs.Contains("LA#DO#FA#") || KeyInputs.Contains("DO#FA#LA#"))
        {
            KeyInputs = ("");
            Debug.Log("FA# MAJOR PLAYED");
        }
        else if (KeyInputs.Contains("FA#LADO#") || KeyInputs.Contains("LADO#FA#") || KeyInputs.Contains("DO#FA#LA"))
        {
            KeyInputs = ("");
            Debug.Log("FA# MINOR PLAYED");
        }
        else if (KeyInputs.Contains("FA#LA#RE") || KeyInputs.Contains("LA#REFA#") || KeyInputs.Contains("REFA#LA#"))
        {
            KeyInputs = ("");
            Debug.Log("FA# AUGMENTED PLAYED");
        }
        else if (KeyInputs.Contains("FA#LADO/8") || KeyInputs.Contains("LADO/8FA#") || KeyInputs.Contains("DO/8FA#LA") || KeyInputs.Contains("DOFA#LA"))
        {
            KeyInputs = ("");
            Debug.Log("FA# DIMINISHED PLAYED");
        }

        // SOL //
        // MAJOR// MINOR// AUGMENTED// DIMINISHED
        if (KeyInputs.Contains("SOLSIRE") || KeyInputs.Contains("SIRESOL") || KeyInputs.Contains("RESOLSI"))
        {
            KeyInputs = ("");
            Debug.Log("SOL MAJOR PLAYED");
        }
        else if (KeyInputs.Contains("SOLLA#RE") || KeyInputs.Contains("LA#RESOL") || KeyInputs.Contains("RESOLLA#"))
        {
            KeyInputs = ("");
            Debug.Log("SOL MINOR PLAYED");
        }
        else if (KeyInputs.Contains("SOLSIRE#") || KeyInputs.Contains("SIRE#SOL") || KeyInputs.Contains("RE#SOLSI"))
        {
            KeyInputs = ("");
            Debug.Log("SOL AUGMENTED PLAYED");
        }
        else if (KeyInputs.Contains("SOLLA#DO#") || KeyInputs.Contains("LA#DO#SOL") || KeyInputs.Contains("DO#SOLLA#"))
        {
            KeyInputs = ("");
            Debug.Log("SOL DIMINISHED PLAYED");
        }

        // SOL# //
        // MAJOR// MINOR// AUGMENTED// DIMINISHED
        if (KeyInputs.Contains("SOL#DO/8RE#") || KeyInputs.Contains("DO/8RE#SOL#") || KeyInputs.Contains("RE#SOL#DO/8") || KeyInputs.Contains("SOL#DORE#") || KeyInputs.Contains("DORE#SOL#") || KeyInputs.Contains("RE#SOL#DO"))
        {
            KeyInputs = ("");
            Debug.Log("SOL MAJOR PLAYED");
        }
        else if (KeyInputs.Contains("SOLLA#RE") || KeyInputs.Contains("LA#RESOL") || KeyInputs.Contains("RESOLLA#"))
        {
            KeyInputs = ("");
            Debug.Log("SOL MINOR PLAYED");
        }
        else if (KeyInputs.Contains("SOLSIRE#") || KeyInputs.Contains("SIRE#SOL") || KeyInputs.Contains("RE#SOLSI"))
        {
            KeyInputs = ("");
            Debug.Log("SOL AUGMENTED PLAYED");
        }
        else if (KeyInputs.Contains("SOLLA#DO#") || KeyInputs.Contains("LA#DO#SOL") || KeyInputs.Contains("DO#SOLLA#"))
        {
            KeyInputs = ("");
            Debug.Log("SOL DIMINISHED PLAYED");
        }

        
        else
        {
            Debug.Log("Missing a note to complete sequence");
		}
    }

    public void HARDRESET() 
    {
        KeyInputs = ("");
        console.text = "";
        Debug.Log("Sequence hard reset");
    }
}
