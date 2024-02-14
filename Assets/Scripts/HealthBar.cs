using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
   public Image bar;
   public Gradient gradient;

   public void Fill(float amountNormalized)
    bar.fillAmount = amountNormalized; 
    bar.color = gradient.Evaluate(amountNormalized);

}