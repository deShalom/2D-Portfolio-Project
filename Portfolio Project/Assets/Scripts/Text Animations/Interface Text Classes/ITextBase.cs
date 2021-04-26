using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace TextClasses
{
    interface ITextBase
    {
        #region Text information properties.
        TMP_TextInfo textInfo { get; set; }
        TMP_CharacterInfo charInfo { get; set; }
        Vector3[] verts { get; set; }
        Vector3 orig { get; set; }
        #endregion

        void AssignValues();

        IEnumerator Animate();

        void ForceMeshUpdate();
    }
}
