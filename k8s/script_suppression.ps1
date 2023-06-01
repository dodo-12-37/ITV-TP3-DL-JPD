$Namespace_aModifier = "NAMESPACE"
$NodePort_aModifier = 4441919

[string[]]$Namespace_list = "unitaire", "acceptation", "production"
[int[]] $NodePort_list = 30000, 30001, 30002


# for ($i = 0, $i -lt $Namespace_list.Length, $i++){
#     # [int] $NodePort = $NodePort_list[$i]
#     # $Namespace = $Namespace_list[$i]

#     $fileData = (Get-Content .\deploy\config.yaml) -creplace $Namespace_aModifier, $Namespace_list[$i] -creplace $NodePort_aModifier, $NodePort_list[$i]
#     $fileData | Set-Content .\deploy\fichiersCreer\$Namespace_list[$i].yaml
#     $fileData | kubectl apply -f - 
# }


$i = 0
foreach ($Namespace in $Namespace_list) {
    write-host ""
    write-host "--- Suppression des déploiements : $Namespace ---"
    $fileData = (Get-Content .\deploy\config.yaml) -creplace $Namespace_aModifier, $Namespace -creplace $NodePort_aModifier, $NodePort_list[$i]
    # $fileData | Set-Content .\deploy\fichiersCreer\$Namespace.yaml
    $fileData | kubectl delete -f - 
    $i++
}

write-host ""
write-host "Terminer"
write-host ""
