using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
using System;
using UnityEngine.UI;

public class ExampleClass : MonoBehaviour
{
    public Text ResultsField;
    public getQueryInput newInput = new getQueryInput();


    // Use this for initialization
    public void ProceedQuery(Text t)
    {
        //GameObject cell = new GameObject ("image");
        getImageUrl(t.text);
        Debug.Log(t.text);
        //getImageUrl (Query, urlL);
        PlayerPrefs.SetString("query_name", t.text);
        //EditorSceneManager.LoadScene("resultSceneBackup");

        //EditSceneManager.LoadScene("MainScene 2");
        //StartCoroutine (getImage());

    }


    public void getImageUrl(string query)
    {
        //FirebaseApp.DefaultInstance.SetEditorDatabaseUrl ("https://fypwebsearch.firebaseio.com/");
        try
        {
            Debug.Log("I am Taking");

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://ec2-54-168-30-20.ap-northeast-1.compute.amazonaws.com/search");
            request.Method = "POST";
            request.Headers["query"] = query;
            request.ContentType = "application/json; charset=UTF-8";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                Debug.Log("here");
                string json = "{\"query\":\"" + query + "\"}";
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                PlayerPrefs.SetString("QueryResultsInJson", result);
                //JObject urlJson = JObject.Parse(result);

                //Debug.Log(urlJson.GetValue("0")["0"]);
            }
            EditorSceneManager.LoadScene("testscene");

            /*string firebaseUrl = "https://fypwebsearch.firebaseio.com/query/" + query + "/url.json";
		WWW w = new WWW (firebaseUrl);
		StartCoroutine (WaitForRequest (w));*/
        }
        //urls urlList = new urls ();
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        //yield return query;

    }
}
