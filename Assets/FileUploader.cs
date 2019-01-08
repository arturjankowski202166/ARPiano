
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class FileUploader : MonoBehaviour
{
    public void Upload(string filename, FileStream data)
    {
        Debug.Log("Starting upload");
        StartCoroutine(UploadC(filename, data));
    }

    public static byte[] ReadFully(Stream input)
    {
        byte[] buffer = new byte[16 * 1024];
        using (MemoryStream ms = new MemoryStream())
        {
            int read;
            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                ms.Write(buffer, 0, read);
            }
            return ms.ToArray();
        }
    }

    IEnumerator UploadC(string filename, FileStream data)
    {
        Debug.Log("Starting upload");
        List<IMultipartFormSection> formData = new List<IMultipartFormSection>();
        formData.Add(new MultipartFormFileSection("sampleFile", ReadFully(data), filename,"image/png"));
        UnityWebRequest www = UnityWebRequest.Post("https://afternoon-waters-53445.herokuapp.com/upload", formData);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log("Form upload complete!");
        }
    }
}
