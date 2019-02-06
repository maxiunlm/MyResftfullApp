function multiplyBy(multiply) {
    return (m) => {
        if (!m) {
            return multiply;
        }

        return multiplyBy(m * multiply);
    }
}