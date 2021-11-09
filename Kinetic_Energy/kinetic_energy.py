# Create the kinetic_energy function.
def kinetic_energy(mass, velocity):
    # The formula for kinetic energy.
    # 0.5 * mass * velocity**2

    kinetic_energy = 0.5 * float(mass) * float(velocity)**2
    return kinetic_energy

# Main function
def main():
    # Ask for the mass in kilograms.
    mass = input("Enter mass in kilograms: ")
    # Ask for the velocity in meters per second.
    velocity = input("Enter velocity in meters per second: ")

    # Run the kinetic_energy function and return the 'answer'
    print ("The object kinetic energy is: ", round(kinetic_energy(mass, velocity), 2), "J.")

# Call main function
main()