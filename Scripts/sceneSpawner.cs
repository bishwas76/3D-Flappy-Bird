
using UnityEngine;

public class sceneSpawner : MonoBehaviour
{
    [SerializeField] private GameObject gameField;
    [SerializeField] private int scenePosition;
    [SerializeField] private Transform gameSceneParant;

    public void FieldSpawner()
    {
       GameObject InstantiatedgameField = Instantiate(gameField, new Vector3(0, 0, gameSceneParant.position.z + scenePosition + 640), Quaternion.identity);

        //To instantiate an gameObject in another gameObject as child.
        InstantiatedgameField.transform.SetParent(gameSceneParant);

       scenePosition = scenePosition + 640;
    }
}
