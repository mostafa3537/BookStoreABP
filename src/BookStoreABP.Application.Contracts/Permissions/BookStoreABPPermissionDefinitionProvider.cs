using BookStoreABP.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace BookStoreABP.Permissions;

public class BookStoreABPPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BookStoreABPPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(BookStoreABPPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(BookStoreABPPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(BookStoreABPPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(BookStoreABPPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BookStoreABPPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookStoreABPResource>(name);
    }
}
