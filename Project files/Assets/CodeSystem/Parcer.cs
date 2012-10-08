using UnityEngine;
using System.Collections;
using System;

public class Parcer : MonoBehaviour {
	
	public static void parceCode(String rawCode) {
        String[] keywords;
        
        // put each line into a String array
		String[] lines = rawCode.Split('\n');

        //go though each line
        for (int i = 0; i < lines.Length; i++) {
            parceLine(lines[i]);
        }
	}

    private static void parceLine(String line)
    {
        //clean out white space
        while (line.StartsWith("\t") || line.StartsWith(" ")) {
            line = line.Substring(1);
        }


    }
}
