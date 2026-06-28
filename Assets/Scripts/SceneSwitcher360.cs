using UnityEngine;

public class SceneSwitcher360 : MonoBehaviour
{
    public Transform xrOrigin;

    public Transform jalanDepan;
    public Transform pameran1;
    public Transform pameran2;
    public Transform pameran3;
    public Transform depanGedungB;
    public Transform depanGedungA;
    public Transform lobbyGedungA;
    public Transform tangga;

    public Transform gedungA_1;
    public Transform gedungA_2;
    public Transform gedungA_3;

    public Transform cabang3;
    public Transform pegadaian;
    public Transform neuro;
    public Transform inspiring1;
    public Transform inspiring2;

    public Transform cabang4;
    public Transform cabang4_A;
    public Transform cabang4_B;
    public Transform cabang4_C;
    public Transform koleksiA;
    public Transform koleksiB;

    public Transform gedungB1;
    public Transform gedungB2;
    public Transform gedungB3;
    public Transform gedungB3_Kanan;
    public Transform gedungB3_Kiri;

    private void MoveTo(Transform target)
    {
        if (xrOrigin == null || target == null)
        {
            Debug.LogWarning(
                "XR Origin atau target lokasi belum diisi di SceneSwitcher360."
            );

            return;
        }

        xrOrigin.position = target.position;
        xrOrigin.rotation = Quaternion.identity;
    }

    public void GoToJalanDepan() => MoveTo(jalanDepan);
    public void GoToPameran1() => MoveTo(pameran1);
    public void GoToPameran2() => MoveTo(pameran2);
    public void GoToPameran3() => MoveTo(pameran3);

    public void GoToDepanGedungB() => MoveTo(depanGedungB);
    public void GoToDepanGedungA() => MoveTo(depanGedungA);
    public void GoToLobbyGedungA() => MoveTo(lobbyGedungA);
    public void GoToTangga() => MoveTo(tangga);

    public void GoToGedungA_1() => MoveTo(gedungA_1);
    public void GoToGedungA_2() => MoveTo(gedungA_2);
    public void GoToGedungA_3() => MoveTo(gedungA_3);

    public void GoToCabang3() => MoveTo(cabang3);
    public void GoToPegadaian() => MoveTo(pegadaian);
    public void GoToNeuro() => MoveTo(neuro);
    public void GoToInspiring1() => MoveTo(inspiring1);
    public void GoToInspiring2() => MoveTo(inspiring2);

    public void GoToCabang4() => MoveTo(cabang4);
    public void GoToCabang4_A() => MoveTo(cabang4_A);
    public void GoToCabang4_B() => MoveTo(cabang4_B);
    public void GoToCabang4_C() => MoveTo(cabang4_C);
    public void GoToKoleksiA() => MoveTo(koleksiA);
    public void GoToKoleksiB() => MoveTo(koleksiB);

    public void GoToGedungB1() => MoveTo(gedungB1);
    public void GoToGedungB2() => MoveTo(gedungB2);
    public void GoToGedungB3() => MoveTo(gedungB3);
    public void GoToGedungB3_Kanan() => MoveTo(gedungB3_Kanan);
    public void GoToGedungB3_Kiri() => MoveTo(gedungB3_Kiri);
}