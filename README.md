# BetterTeslas

# Config
| Name | Type | Description | Default |
| --- | --- | --- | --- |
| IsEnabled | bool | Is the plugin enabled | true |
| RandomDamage | bool | If inflicted damage may be smaller or larger than value on a list | false |
| RandomDamageMaxValue | int | Maximum value for smaller or larger damage amount, ignored if damage from the list is equal to 0 (Damage from the list +/- from 0 to this value) | 20 |
| ScpDamageAmount | Dictionary<RoleType, float> | SCPs list with damage amount which tesla will inflict to them (Rerember that one Tesla burst hits 2 or 3 times) | Defualt float values makes that all of SCPs (expect 106) dies from 2 Tesla bursts if they have full HP |

# Defualt damage values
- Scp049:  <b>425</b> 
- Scp0492:  <b>50</b> 
- Scp096:  <b>375</b> 
- Scp106:  <b>325</b> 
- Scp173:  <b>534</b> 
- Scp93953:  <b>367</b> 
- Scp93989:  <b>367</b> 
