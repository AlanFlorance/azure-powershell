<!--
    Please leave this section at the top of the change log.

    Changes for the upcoming release should go under the section titled "Upcoming Release", and should adhere to the following format:

    ## Upcoming Release
    * Overview of change #1
        - Additional information about change #1
    * Overview of change #2
        - Additional information about change #2
        - Additional information about change #2
    * Overview of change #3
    * Overview of change #4
        - Additional information about change #4

    ## YYYY.MM.DD - Version X.Y.Z (Previous Release)
    * Overview of change #1
        - Additional information about change #1
-->
## Upcoming Release
*  Upgraded API verision from 2020-02-14 to 2022-02-14.
    - Supported parameter `replicationRegions` in JSON file for `New-AzImageBuilderTemplate`. [#18924]
    - Added parameter `VMProfileUserAssignedIdentity` in `New-AzImageBuilderTemplate`. [#17273]
    - Added parameter `IdentityType` in `New-AzImageBuilderTemplate`.
    - Added a cmdlet named `New-AzImageBuilderTemplateValidatorObject` to create an in-memory object for ImageTemplateValidator.
*  Replaced parameter `UserAssignedIdentityId <string>` with `UserAssignedIdentity <Hashtable>`.
*  Renamed `Get-AzImageBuilderRunOutput` to `Get-AzImageBuilderTemplateRunOutput`.
*  Renamed `New-AzImageBuilderCustomizerObject` to `New-AzImageBuilderTemplateCustomizerObject`.
*  Renamed `New-AzImageBuilderDistributorObject` to `New-AzImageBuilderTemplateDistributorObject`
*  Renamed `New-AzImageBuilderSourceObject` to `New-AzImageBuilderTemplateSourceObject`.

## Version 0.2.0
* Added support for runAsSystem parameter in `New-AzImageBuilderCustomizerObject` [#13163]
* Added support to create template basing on imported json in `New-AzImageBuilderTemplate`. [#12634]

## Version 0.1.2
* Removed `Sha256Checksum` parameter from example of `New-AzImageBuilderCustomizerObject`.

## Version 0.1.1
* Made `Sha256Checksum` optional in `New-AzImageBuilderCustomizerObject`.

## Version 0.1.0
* the first preview release

