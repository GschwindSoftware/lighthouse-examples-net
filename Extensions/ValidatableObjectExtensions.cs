namespace System.ComponentModel.DataAnnotations;

/// <summary>
/// Stellt Erweiterungsmethoden für <see cref="IValidatableObject"/> zur Verfügung
/// </summary>
internal static class ValidatableObjectExtensions {

    /// <summary>
    /// Löst eine <see cref="ValidationException"/> aus, falls das übergebene <see cref="IValidatableObject"/> ungültig ist
    /// </summary>
    /// <param name="validatable">Das zu prüfende <see cref="IValidatableObject"/></param>
    internal static void ThrowIfInvalid(this IValidatableObject validatable) {
        var errors = validatable.Validate(null!);
        if (errors.FirstOrDefault() is {} err)
            throw new ValidationException(err, null, validatable);
    }

}
