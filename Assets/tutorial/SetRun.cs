using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Com.MyCompany.MyGame
{
    public class SetRun : MonoBehaviour
    {
        public GameObject tt;
        // Use this for initialization
        void Start()
        {
            tt.GetComponent<AiTutorial>().enabled = false;
        }

        // Update is called once per frame
        void Update()
        {
            tt.GetComponent<AiTutorial>().enabled = false;

            // Invoke("settutorialai",2.5f);
            StartCoroutine(setRun());
        }
        void settutorialai()
        {
            tt.GetComponent<AiTutorial>().enabled = true;
            this.gameObject.SetActive(false);

        }
        private IEnumerator setRun()
        {
            yield return new WaitForSeconds(2.5f);
            tt.GetComponent<AiTutorial>().enabled = true;
            this.gameObject.SetActive(false);


        }
    }
}
