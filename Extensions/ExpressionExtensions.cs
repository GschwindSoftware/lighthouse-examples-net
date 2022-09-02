using System.Reflection;

namespace System.Linq.Expressions;

/// <summary>
/// Stellt Erweiterungsmethoden für <see cref="Expression"/> zur Verfügung.
/// </summary>
internal static class ExpressionExtensions {

    /// <summary>
    /// Ruft den Pfad der Eigenschaften ab, auf den durch den Ausdruck zugegriffen wird.
    /// </summary>
    /// <param name="expression">Der Ausdruck.</param>
    /// <returns>Die Liste von Eigenschaften, die den Pfad bilden.</returns>
    internal static IReadOnlyCollection<PropertyInfo> GetPropertyAccessList(this LambdaExpression expression) {
        if (expression.Parameters.Count != 1)
            throw new ArgumentOutOfRangeException(nameof(expression), "Der Ausdruck muss exakt einen Parameter besitzen.");

        var param = expression.Parameters.Single();
        return GetPropertyAccessList(expression.Body, param).Reverse().ToArray();
    }

    static IEnumerable<PropertyInfo> GetPropertyAccessList(Expression expression, ParameterExpression param) {
        var memberExpression = (MemberExpression)SanitizeConvert(expression);

        if (memberExpression is not { Member: PropertyInfo propertyInfo })
            throw new MemberAccessException("Member ist keine Eigenschaft.");

        yield return propertyInfo;

        if (memberExpression.Expression != param && memberExpression.Expression != null)
            foreach (var p in GetPropertyAccessList(memberExpression.Expression, param))
                yield return p;
    }

    static Expression SanitizeConvert(Expression expression) {
        while (IsConvertExpression(expression))
            expression = SanitizeConvert(((UnaryExpression)expression).Operand);

        return expression;
    }

    static bool IsConvertExpression(Expression expression) =>
        expression.NodeType == ExpressionType.Convert ||
        expression.NodeType == ExpressionType.ConvertChecked;

}