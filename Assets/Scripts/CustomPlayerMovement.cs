using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Inherit from Start Asset Inputs to allow thrid person character to work correctly.
/// You still have access to all Monobehavior stuff, in addition these variables:
///     1) Vector2 move
///     2) Vector2 look
///     3) bool jump
///     4) bool sprint
/// Change those values to change the character actions
/// (if you are unsure of this, look at the StarterAssetsInputs and ThirdPersonController scripts)
public class CustomPlayerMovement : StarterAssets.StarterAssetsInputs
{

}
