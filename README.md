# Dependency Injection Example

This practice demonstrates Dependency Injection (DI) in C#. It includes two classes: `Teacher` and `ClassRoom`.

## Classes

### Teacher Class
- **Properties:**
  - `FirstName: string`
  - `LastName: string`
- **Method:**
  - `GetInfo()`: Returns the teacher's full name.

### ClassRoom Class
- **Property:**
  - `Teacher: ITeacher`
- **Method:**
  - `GetTeacherInfo()`: Returns the teacher's information by calling `GetInfo()`.

## Usage

1. Implement the `ITeacher` interface for the `Teacher` class.
2. Create a `Teacher` instance and pass it to the `ClassRoom` constructor.
3. Call `GetTeacherInfo()` to display the teacher's details.

This example illustrates how DI reduces class dependencies and promotes flexibility.
