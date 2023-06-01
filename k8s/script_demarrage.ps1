$Namespace_aModifier = "NAMESPACE"
$NodePort_aModifier = 4441919

[string[]]$Namespace_list = "unitaire", "acceptation", "production"
[int[]] $NodePort_list = 30000, 30001, 30002


$i = 0
foreach ($Namespace in $Namespace_list) {
    write-host ""
    write-host "--- Démarrage des déploiements : $Namespace ---"
    $fileData = (Get-Content .\deploy\config.yaml) -creplace $Namespace_aModifier, $Namespace -creplace $NodePort_aModifier, $NodePort_list[$i]
    # $fileData | Set-Content .\deploy\fichiersCreer\$Namespace.yaml    # Uniquement pour visualiser les fichiers résultants
    $fileData | kubectl apply -f - 
    $i++
}

write-host ""
write-host "Terminer"
write-host ""
