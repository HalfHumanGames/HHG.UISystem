using HHG.Common.Runtime;
using UnityEngine;

namespace HHG.UISystem.Runtime
{
    [CreateAssetMenu(fileName = "View Name", menuName = "HHG/Assets/Variable/View Name")]
    public class ViewNameAsset : StringAsset
    {
        [SerializeField] private GameObject view;

        private void OnValidate()
        {
            if (view != null && view.GetComponent<UIView>() is UIView ui)
            {
                value = ui.GetType().AssemblyQualifiedName;
            }
        }
    }
}