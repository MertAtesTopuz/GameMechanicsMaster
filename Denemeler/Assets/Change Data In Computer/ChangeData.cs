using System.IO;
using UnityEngine;

public class ChangeData : MonoBehaviour
{
    public CharacterController cha;

    private float jump;
    private float speed;

    private string path;

    private class SaveObject
    {
        public float jump;
        public float speed;
    }

    private void Start()
    {

        jump = 7f;
        speed = 5f;

        SaveObject saveObject = new SaveObject
        {
            jump = jump,
            speed = speed
        };

        path = "./KarakterKontrol.txt"; // windows bilgisayara çıktı aldıktan sonra çıktı dosyalarından birini seç ve onun dosya yolunu buraya yaz ardından kontrol et
        string json = JsonUtility.ToJson(saveObject, true);
        File.WriteAllText(path, json);
    }

    private void Update()
    {
        if (File.Exists(path))
        {
            string saveString = File.ReadAllText(path);

            SaveObject saveObject = JsonUtility.FromJson<SaveObject>(saveString);

            cha.jumpForce = saveObject.jump;
            cha.moveSpeed = saveObject.speed;

            Debug.Log("jump = " + saveObject.jump);
            Debug.Log("speed = " + saveObject.speed);
        }
        
    }
}