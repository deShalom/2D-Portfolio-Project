using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TextClasses
{
    public class A_JumpingText : TextBase_A
    {
        private int Counter = 0;

        private void Start()
        {
            AssignValues();
            StartCoroutine("Animate");
        }

        public override IEnumerator Animate()
        {
            while (true)
            {
                text.ForceMeshUpdate();

                int random = Random.Range(0, textInfo.characterCount);

                charInfo = textInfo.characterInfo[Counter];
                verts = textInfo.meshInfo[charInfo.materialReferenceIndex].vertices;

                for (int j = 0; j < 4; j++)
                {
                    orig = verts[charInfo.vertexIndex + j];

                    verts[charInfo.vertexIndex + j] = Vector3.Lerp(orig, new Vector3(orig.x, orig.y + 10f), 0.2f);
                    ForceMeshUpdate();
                }

                if (Counter >= textInfo.characterCount)
                    Counter = 0;
                else
                    Counter++;

                yield return new WaitForSeconds(1);
            }
        }

    }
}
